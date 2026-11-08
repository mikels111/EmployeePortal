namespace EmployeePortal.Server.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
