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
    private readonly IIncrement _increment;

    public NumberController(IBootstrap bootstrap, IIncrement increment) =>
        (_bootstrap, _increment) = (bootstrap, increment);

    [HttpGet("number")]
    public async Task<ActionResult> GetNumbers()
    {
        var numbers = await _bootstrap.Load();

        if (numbers is null)
            return NotFound(new { message = "Files of bootstrap not found" });

        return Ok(numbers);
    }

    [HttpPut("number/{id}")]
    public async Task<ActionResult> IncreaseNumber(
        [FromRoute] int id,
        [FromBody] Increment model
        )
    {  
        if (!ModelState.IsValid)
            return BadRequest(new { message = "Model state is invalid", model = model });

        var number = await _increment.Add(model, id);
        if (number is null)
            return NotFound(new { message = $"Number with id={id} not found" });

        return Ok(number);
    }
}
