using Dto;
using Entity.EntityPrometre;
using Interfaces.ServiceManager;
using Microsoft.AspNetCore.Http.HttpResults;
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
    [HttpGet("{id:guid}",Name ="getAProduct")]
    public IActionResult GetProduct(Guid id)
    {
        var product = _service.productService.findProductById(id, false);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }
    [Route("findbyname")]
    [HttpGet()]
    public IActionResult GetProductbyName([FromQuery] ProductParametre productparametrs)
    {
        var product = _service.productService.findProductByName(productparametrs, false);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }
    [HttpPost]
    public async Task<IActionResult> giveProduct([FromBody] ProductAddDto productAddDto)
    {
        if(productAddDto is null)
        return  BadRequest("We cant found");
        var product= await _service.productService.cerateProduct(productAddDto);
        return CreatedAtRoute("getAProduct",new {id= product.id},product);
    }
}
