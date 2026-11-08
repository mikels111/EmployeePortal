namespace EmployeePortal.Server.Entities
{
    public class RequestType
    {
        public int RequestTypeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Request> Requests { get; set; } = new List<Request>();
    }
}
