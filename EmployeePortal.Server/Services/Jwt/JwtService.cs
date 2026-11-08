using EmployeePortal.Server.Dto.User;
using EmployeePortal.Server.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EmployeePortal.Server.Services.Jwt
{
    public class JwtService : IJwtService
    {
        public async Task<SecurityToken> GenerateJWT(UserGetDto user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("Jwt__Key")));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Mail", user.Email),
                    new Claim("Name", user.Email.Split('@')[0])
                }),
                Expires = DateTime.Now.AddMinutes(Convert.ToDouble(Environment.GetEnvironmentVariable("Jwt__ExpireMinutes"))),
                Issuer = Environment.GetEnvironmentVariable("Jwt__Issuer"),
                Audience = Environment.GetEnvironmentVariable("Jwt__Audience"),
                SigningCredentials = credentials
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwt = tokenHandler.CreateToken(tokenDescriptor);
            return jwt;
        }

    }
}
