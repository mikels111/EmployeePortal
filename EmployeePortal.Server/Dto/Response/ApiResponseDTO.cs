namespace EmployeePortal.Server.Dto.Response
{
    public class ApiResponseDTO<T>(bool success, string message, T? data, object? errors = null)
    {
        public bool? Success { get; set; } = success;
        public string? Message { get; set; } = message;
        public T? Data { get; set; } = data;
        public object? Errors { get; set; } = errors;
    }
}
