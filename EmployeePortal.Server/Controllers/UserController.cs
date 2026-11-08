using EmployeePortal.Server.Data;
using EmployeePortal.Server.Dto.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EmployeePortal.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        //private readonly AppDbContext _AppDbContext;
        //public UserController(AppDbContext appDbContext)
        //{
        //    _AppDbContext = appDbContext;
        //}

        //[HttpGet("get-user-info/{userId}")]
        //public async Task<IActionResult> GetUserInfo(int userId)
        //{
        //    var user = await _AppDbContext
        //        .Users
        //        .Include(u => u.Role)
        //        .FirstOrDefaultAsync(m => m.UserId == userId);

        //    if (user == null)
        //        return NotFound();

        //    var userDto = new UserGetDto
        //    {
        //        UserId = user.UserId,
        //        Email = user.Email,
        //        Name = user.Name,
        //        LastName = user.LastName,
        //        Birthday = user.Birthday,
        //        HolidayHours = user.HolidayHours,
        //        FreeHours = user.FreeHours,
        //        Role = new RoleDto
        //        {
        //            RoleId = user.Role.RoleId,
        //            Name = user.Role.Name
        //        }
        //    };
        //    Console.WriteLine($"UserId: {userId}, User: {user?.Name} {user?.LastName}");
        //    return Ok(userDto);
        //}
    }
}
