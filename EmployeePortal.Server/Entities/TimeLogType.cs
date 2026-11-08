namespace EmployeePortal.Server.Entities
{
    public class TimeLogType
    {
        public int TimeLogTypeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<TimeLog> TimeLogs { get; set; } = new List<TimeLog>();
    }
}