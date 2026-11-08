namespace EmployeePortal.Server.Entities
{
    public class RequestStatus
    {
        public int RequestStatusId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Request> Requests { get; set; } = new List<Request>();
    }
}
