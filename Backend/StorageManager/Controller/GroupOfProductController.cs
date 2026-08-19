using Dto;
using Interfaces.ServiceManager;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace StorageManager.Controller;

[Route("api/GroupOfProduct")]
[ApiController]
public class GroupOfProductController:ControllerBase
{
        private readonly ISeviceManager _service;
    public GroupOfProductController(ISeviceManager service)
    {
        _service=service;
    }

    [HttpPost("[Action]")]
    public async Task<IActionResult> createGroupOfProduct([FromBody] GroupOfProductCreatDto groupOfProductCreatDto)
    {
        if(groupOfProductCreatDto is null)
        return BadRequest("please enter a name");

        var groupOfProduct= await _service.groupOfProductSevice.CtreateGroupOfProudct(groupOfProductCreatDto);

        return Ok();

    }
    [HttpGet("[Action]")]
    public async Task<IActionResult> GetAllGroupOfProduct()
    {
        var groupOfProduct= await _service.groupOfProductSevice.getAllGroupOfProduce(false);
        if(groupOfProduct is null)
        return NotFound();
        return Ok(groupOfProduct);
    }
}
