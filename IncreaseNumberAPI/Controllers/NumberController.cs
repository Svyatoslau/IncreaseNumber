using IncreaseNumberAPI.Models.API;
using IncreaseNumberAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncreaseNumberAPI.Controllers;
[Route("api")]
[ApiController]
public class NumberController : ControllerBase
{
    private readonly IBootstrap _bootstrap;

    public NumberController(IBootstrap bootstrap) =>
        (_bootstrap) = (bootstrap);

    [HttpGet("number")]
    public async Task<ActionResult> GetNumbers()
    {
        var numbers = await _bootstrap.Load();

        if (numbers is null)
        {
            return NotFound(new { message = "Files of bootstrap not found" }); 
        }
        
        return Ok(numbers);
    }

    [HttpPut("number/{id}")]
    public ActionResult IncreaseNumber(
        [FromRoute] int id,
        [FromBody] Increment model
        )
    {  
        Console.WriteLine(id);
        return Ok(id);
    }
}
