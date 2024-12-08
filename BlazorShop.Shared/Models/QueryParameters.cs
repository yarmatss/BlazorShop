namespace BlazorShop.Shared.Models;

public class QueryParameters
{
    const int maxPageSize = 50;
    public int PageNumber { get; set; } = 1;
    private int pageSize = 30;
    public int PageSize
    {
        get => pageSize;
        set => pageSize = value > maxPageSize ? maxPageSize : value;
    }

    //Filtering parameters
    public string? Title { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }

    //Sorting parameters
    public string? OrderBy { get; set; }
    public bool OrderAsc { get; set; } = true;
}
