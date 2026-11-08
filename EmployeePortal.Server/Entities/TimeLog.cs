namespace EmployeePortal.Server.Entities
{
    public class TimeLog
    {
        public int TimeLogId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TimeLogStatusId { get; set; }
        public TimeLogStatus TimeLogStatus { get; set; }
        public int TimeLogTypeId { get; set; }
        public TimeLogType TimeLogType { get; set; }
        public DateTime Time { get; set; }
        public string? Notes { get; set; }
    }
}
