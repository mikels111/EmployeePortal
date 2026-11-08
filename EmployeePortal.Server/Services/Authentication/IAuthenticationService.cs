using EmployeePortal.Server.Dto.Authentication;

namespace EmployeePortal.Server.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<AuthenticationTokenDTO> Login(AutheticationLoginDTO request);
        string HashPassword(string password);
    }
}
