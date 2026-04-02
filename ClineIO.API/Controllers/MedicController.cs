using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ClineIO.API.Controllers;

[ApiController]
[Route("api/medics")]
public class MedicController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllMedics()
    {
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetMedicById(Guid id)
    {
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> AddMedic()
    {
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateMedic(Guid id)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMedic(Guid id)
    {
        return NoContent();
    }
}