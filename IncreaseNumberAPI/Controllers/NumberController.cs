using IncreaseNumberAPI.Models.API;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncreaseNumberAPI.Controllers;
[Route("api")]
[ApiController]
public class NumberController : ControllerBase
{
    [HttpGet("number")]
    public ActionResult GetNumbers()
    {


        return Ok();
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
