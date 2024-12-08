using BlazorShop.Shared.Models;
using System.Net.Http.Json;

namespace BlazorShop.Shared.Services.ProductsService;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ServiceResponse<Product>> CreateProductAsync(Product newProduct)
    {
        var response = await _httpClient.PostAsJsonAsync("/api/Products", newProduct);
        var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Product>>();
        return result;
    }

    public async Task<ServiceResponse<bool>> DeleteProductAsync(int id)
    {
        var response = await _httpClient.DeleteAsync($"/api/Products/{id}");
        var result = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        return result;
    }

    public async Task<ServiceResponse<Product>> GetProductAsync(int id)
    {
        var response = await _httpClient.GetAsync($"/api/Products/{id}");
        var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Product>>();
        return result;
    }

    public async Task<ServiceResponse<List<Product>>> GetProductsAsync(QueryParameters parameters)
    {
        try
        {
            var query = $"?PageNumber={parameters.PageNumber}&PageSize={parameters.PageSize}";

            if (!string.IsNullOrEmpty(parameters.Title))
            {
                query += $"&Title={parameters.Title}";
            }

            if (parameters.MinPrice.HasValue)
            {
                query += $"&MinPrice={parameters.MinPrice.Value}";
            }

            if (parameters.MaxPrice.HasValue)
            {
                query += $"&MaxPrice={parameters.MaxPrice.Value}";
            }

            if (!string.IsNullOrEmpty(parameters.OrderBy))
            {
                query += $"&OrderBy={parameters.OrderBy}&OrderAsc={parameters.OrderAsc}";
            }

            var response = await _httpClient.GetAsync($"/api/Products{query}");
            if (!response.IsSuccessStatusCode)
            {
                return new ServiceResponse<List<Product>>
                {
                    Success = false,
                    Message = "Failed to load products: " + response.ReasonPhrase
                };
            }

            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<List<Product>>>();
            return result;
        }
        catch (Exception ex)
        {
            return new ServiceResponse<List<Product>>
            {
                Success = false,
                Message = ex.Message
            };
        }
    }

    public async Task<ServiceResponse<Product>> UpdateProductAsync(Product updatedProduct)
    {
        try
        {
            var response = await _httpClient.PutAsJsonAsync("/api/Products", updatedProduct);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Product>>();
            return result;
        }
        catch (HttpRequestException ex)
        {
            return new ServiceResponse<Product>
            {
                Success = false,
                Message = "Failed to load product: " + ex.Message
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<Product>
            {
                Success = false,
                Message = ex.Message
            };
        }
    }
}
