namespace EmployeePortal.Server.Dto.User
{
    public class UserGetDto
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthday { get; set; }
        public int HolidayHours { get; set; }
        public int FreeHours { get; set; }
        public RoleDto Role { get; set; }
    }

    public class RoleDto
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
    }
}
