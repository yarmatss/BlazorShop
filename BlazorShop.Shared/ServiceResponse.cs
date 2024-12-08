namespace BlazorShop.Shared;

public class ServiceResponse<T>
{
    public T? Data { get; set; } = default;
    public bool Success { get; set; } = false;
    public string? Message { get; set; } = default;
    public int? TotalCount { get; set; } = default;
}
