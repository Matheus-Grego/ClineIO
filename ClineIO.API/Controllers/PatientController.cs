using Microsoft.AspNetCore.Mvc;

namespace ClineIO.API.Controllers;

[ApiController]
[Route("api/patient")]
public class PatientController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllPatients()
    {
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPatientById(Guid id)
    {
        return NoContent();
    }
    
    [HttpPost]
    public async Task<IActionResult> AddPatient(){
        return NoContent();
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePatient(Guid id)
    {
        return NoContent();
    }
    
}