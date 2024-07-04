namespace AquarioMania.Models;

public class ServiceResponse<T>
{
    public int? Status { get; set; }
    public bool Success { get; set; } = true;
    public string? Message { get; set; }
    public string DeveloperMessage { get; set; } = "";
    public T? Data { get; set; }
    public string? Error { get; set; }
}