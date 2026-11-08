namespace EmployeePortal.Server.Entities
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public TimeSpan EnterTime { get; set; }
        public TimeSpan ExitTime { get; set; }
        public string Name { get; set; }
    }
}
