using BlazorShop.API.Data;
using BlazorShop.Shared;
using BlazorShop.Shared.Models;
using BlazorShop.Shared.Services.ProductsService;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.API.Services;

public class ProductService : IProductService
{
    private readonly DataContext _context;

    public ProductService(DataContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<Product>> CreateProductAsync(Product newProduct)
    {
        var result = new ServiceResponse<Product>();

        try
        {
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();

            result.Data = newProduct;
            result.Success = true;
            result.Message = "Product created successfully";
        }
        catch (Exception ex)
        {
            result.Message = $"Error creating product: {ex.Message}";
            result.Success = false;
        }

        return result;
    }

    public async Task<ServiceResponse<List<Product>>> GetProductsAsync(QueryParameters parameters)
    {
        var result = new ServiceResponse<List<Product>>();

        try
        {
            var allProducts = _context.Products.AsQueryable();

            // Filtering
            if (!string.IsNullOrEmpty(parameters.Title))
            {
                allProducts = allProducts.Where(p => p.Title.Contains(parameters.Title));
            }

            if (parameters.MinPrice.HasValue)
                allProducts = allProducts.Where(p => p.Price >= parameters.MinPrice.Value);

            if (parameters.MaxPrice.HasValue)
                allProducts = allProducts.Where(p => p.Price <= parameters.MaxPrice.Value);

            // Sorting
            if (!string.IsNullOrEmpty(parameters.OrderBy))
            {
                if (parameters.OrderAsc)
                    allProducts = allProducts.OrderBy(p => EF.Property<object>(p, parameters.OrderBy));
                else
                    allProducts = allProducts.OrderByDescending(p => EF.Property<object>(p, parameters.OrderBy));
            }
            else
            {
                // Default ordering by Id
                allProducts = allProducts.OrderBy(p => p.Id);
            }

            // Pagination
            var pagedProducts = await allProducts
                .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .ToListAsync();

            result.Data = pagedProducts;
            result.Success = true;
            result.Message = "Products retrieved successfully";
            result.TotalCount = await allProducts.CountAsync();
        }
        catch (Exception ex)
        {
            result.Message = $"Error retrieving products: {ex.Message}";
            result.Success = false;
        }

        return result;
    }

    public async Task<ServiceResponse<Product>> GetProductAsync(int id)
    {
        var result = new ServiceResponse<Product>();

        try
        {
            result.Data = await _context.Products.FirstAsync(p => p.Id == id);
            result.Success = true;
            result.Message = "Product retrieved successfully";
        }
        catch (Exception ex)
        {
            result.Message = $"Error retrieving product: {ex.Message}";
            result.Success = false;
        }

        return result;
    }

    public async Task<ServiceResponse<bool>> DeleteProductAsync(int id)
    {
        var result = new ServiceResponse<bool>();

        try
        {
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                result.Data = true;
                result.Success = true;
                result.Message = "Product deleted successfully";
            }
        }
        catch (Exception ex)
        {
            result.Message = $"Error deleting product: {ex.Message}";
            result.Success = false;
        }

        return result;
    }

    public async Task<ServiceResponse<Product>> UpdateProductAsync(Product updatedProduct)
    {
        var result = new ServiceResponse<Product>();

        try
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == updatedProduct.Id);
            if (product == null)
            {
                result.Success = false;
                result.Message = $"Product with id {updatedProduct.Id} not found";
                return result;
            }

            _context.Entry(product).CurrentValues.SetValues(updatedProduct);

            await _context.SaveChangesAsync();
            result.Success = true;
            result.Data = updatedProduct;
            result.Message = "Product updated successfully";
            return result;
        }
        catch (Exception ex)
        {
            result.Message = $"Error updating product: {ex.Message}";
            result.Success = false;
            return result;
        }
    }
}
