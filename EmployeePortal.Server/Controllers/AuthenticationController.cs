using EmployeePortal.Server.Dto.Authentication;
using EmployeePortal.Server.Dto.Response;
using EmployeePortal.Server.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _service;
        public AuthenticationController(IAuthenticationService service) => _service = service;

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AutheticationLoginDTO request)
        {
            var response = await _service.Login(request);
            if (!response.Success)
                return Unauthorized(request);

            Response.Cookies.Append("employeePortalToken", response.Token, new CookieOptions
            {
                HttpOnly = false,
                Secure = true,
                SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax,
                Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(Environment.GetEnvironmentVariable("Jwt__ExpireMinutes")))
            });
            return Ok(new ApiResponseDTO<AuthenticationTokenDTO>(true, "Login successful", response));
        }

        [HttpPost("hash-password")]
        public IActionResult HashPassword([FromBody] HashPasswordDTO request)
        {
            var hash = _service.HashPassword(request.Password);
            return Ok(new ApiResponseDTO<string>(true, "Password hashed", hash));
        }
    }
}
