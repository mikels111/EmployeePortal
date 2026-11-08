namespace EmployeePortal.Server.Entities
{
    public class TimeLogStatus
    {
        public int TimeLogStatusId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<TimeLog> TimeLogs { get; set; } = new List<TimeLog>();
    }
}