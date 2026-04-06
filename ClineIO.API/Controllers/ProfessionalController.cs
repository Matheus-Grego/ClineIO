using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ClineIO.API.Controllers;

[ApiController]
[Route("api/professional")]
public class ProfessionalController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllProfessionals()
    {
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProfessionalById(Guid id)
    {
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> AddProfessional()
    {
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProfessional(Guid id)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProfessional(Guid id)
    {
        return NoContent();
    }
}