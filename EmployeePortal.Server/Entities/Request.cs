namespace EmployeePortal.Server.Entities
{
    public class Request
    {
        public int RequestId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int RequestStatusId { get; set; }
        public RequestStatus RequestStatus { get; set; }
        public int RequestTypeId { get; set; }
        public RequestType RequestType { get; set; }
        public int approvedBy { get; set; }

    }
}
