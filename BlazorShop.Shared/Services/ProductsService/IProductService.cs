using BlazorShop.Shared.Models;

namespace BlazorShop.Shared.Services.ProductsService;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProductsAsync(QueryParameters parameters);
    Task<ServiceResponse<Product>> GetProductAsync(int id);
    Task<ServiceResponse<Product>> CreateProductAsync(Product newProduct);
    Task<ServiceResponse<Product>> UpdateProductAsync(Product updatedProduct);
    Task<ServiceResponse<bool>> DeleteProductAsync(int id);
}
