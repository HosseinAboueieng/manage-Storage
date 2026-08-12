using Interfaces.ServiceManager;
using Microsoft.AspNetCore.Mvc;

namespace StorageManager.Controller;

[Route("api/products")]
[ApiController]
public class ProductController:ControllerBase
{
    private readonly ISeviceManager _service;
    public ProductController(ISeviceManager service)
    {
        _service=service;
    }
    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var products=_service.productService.FindAllProductByName(false);
        return Ok(products);
    }
    [HttpGet("{id:guid}")]
    public IActionResult GetProduct(Guid id)
    {
        var product = _service.productService.findProductById(id, false);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }
    
}
