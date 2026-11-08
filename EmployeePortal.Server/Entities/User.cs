namespace EmployeePortal.Server.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthday { get; set; }
        public string Password { get; set; }
        public int HolidayHours { get; set; }
        public int FreeHours { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
