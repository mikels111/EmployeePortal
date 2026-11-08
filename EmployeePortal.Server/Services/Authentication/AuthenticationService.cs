using EmployeePortal.Server.Data;
using EmployeePortal.Server.Dto.Authentication;
using EmployeePortal.Server.Dto.User;
using EmployeePortal.Server.Entities;
using EmployeePortal.Server.Services.Jwt;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EmployeePortal.Server.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly AppDbContext _AppDbContext;
        private readonly IJwtService _jwtService;
        private readonly PasswordHasher<User> _hasher = new();

        public AuthenticationService(AppDbContext appDbContext, IJwtService jwtService)
        {
            _AppDbContext = appDbContext;
            _jwtService = jwtService;
        }

        public async Task<AuthenticationTokenDTO> Login(AutheticationLoginDTO request)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var user = await _AppDbContext.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
                return new AuthenticationTokenDTO { Success = false, Token = null };

            var result = _hasher.VerifyHashedPassword(user, user.Password, request.Password);
            UserGetDto userDTO= new UserGetDto
            {
                UserId = user.UserId,
                Email = user.Email,
                Role = new RoleDto
                {
                    RoleId = user.Role.RoleId,
                    Name = user.Role.Name
                },
            };
            if (result == PasswordVerificationResult.Success)
            {
                // Aquí deberías generar el JWT o token correspondiente
                var jwt = await _jwtService.GenerateJWT(userDTO);
                return new AuthenticationTokenDTO { Success = true, Token = tokenHandler.WriteToken(jwt) };
            }
            else
            {
                return new AuthenticationTokenDTO { Success = false, Token = null };
            }

        }

        public string HashPassword(string password)
        {
            return _hasher.HashPassword(new User(), password);
        }

    }
}
