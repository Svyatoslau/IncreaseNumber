using IncreaseNumberAPI.Models.API;
using IncreaseNumberAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncreaseNumberAPI.Controllers;
[Route("api")]
[ApiController]
public class CounterController : ControllerBase
{
    private readonly IBootstrap _bootstrap;
    private readonly IIncrement _increment;
    private readonly IUpdatePikedDate _pikedDate;
    public CounterController(IBootstrap bootstrap, IIncrement increment, IUpdatePikedDate pikedDate) =>
        (_bootstrap, _increment, _pikedDate) = (bootstrap, increment, pikedDate);

    [HttpGet("counter")]
    public async Task<ActionResult> GetNumbersAsync()
    {
        var counters = await _bootstrap.LoadAsync();
        if (counters is null)
            return NotFound(new { message = "Files of bootstrap not found" });

        return Ok(counters);
    }

    [HttpPut("counter/{id}")]
    public async Task<ActionResult> IncreaseNumberAsync(
        [FromRoute] int id,
        [FromBody] Increment model)
    {
        if (!ModelState.IsValid)
            return BadRequest(new { message = "Model state is invalid", model = model });

        var counter = await _increment.AddAsync(model, id);
        if (counter is null)
            return NotFound(new { message = $"Number with id={id} not found" });

        return Ok(counter);
    }

    [HttpPatch("counter/{id}")]
    public async Task<ActionResult> UpdatePikedDateAsync(
        [FromRoute] int id,
        [FromBody] DateTime model)
    {
        var counter = await _pikedDate.UpdatePikedDateAsync(id, model);

        if (counter is null)
            return NotFound(new { message = $"Number with id={id} not found" });

        return Ok(counter);
    }
}
