using BlazorShop.Shared;
using BlazorShop.Shared.Models;
using BlazorShop.Shared.Services.ProductsService;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts([FromQuery] QueryParameters parameters)
    {
        var response = await _productService.GetProductsAsync(parameters);
        if (response.Success)
        {
            return Ok(response);
        }

        return NotFound(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProduct([FromRoute] int id)
    {
        var response = await _productService.GetProductAsync(id);
        if (response.Success)
        {
            return Ok(response);
        }

        return NotFound(response);
    }

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Product>>> UpdateProduct([FromBody] Product updatedProduct)
    {
        var response = await _productService.UpdateProductAsync(updatedProduct);
        if (response.Success)
        {
            return Ok(response);
        }

        return NotFound(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ServiceResponse<bool>>> DeleteProduct([FromRoute] int id)
    {
        var result = await _productService.DeleteProductAsync(id);
        if (result.Success)
            return Ok(result);
        else
            return StatusCode(500, $"Internal server error {result.Message}");
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Product>>> CreateProduct([FromBody] Product newProduct)
    {
        var result = await _productService.CreateProductAsync(newProduct);
        if (result.Success)
            return Ok(result);
        else
            return StatusCode(500, $"Internal server error {result.Message}");
    }
}
