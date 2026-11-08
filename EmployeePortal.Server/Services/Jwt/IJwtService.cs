using EmployeePortal.Server.Dto.User;
using EmployeePortal.Server.Entities;
using Microsoft.IdentityModel.Tokens;

namespace EmployeePortal.Server.Services.Jwt
{
    public interface IJwtService
    {
        Task<SecurityToken> GenerateJWT(UserGetDto user);
    }
}
