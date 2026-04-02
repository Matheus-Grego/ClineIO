using Microsoft.AspNetCore.Mvc;

namespace ClineIO.API.Controllers;

public class AppointmentsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllApointments()
    {
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAppointmentById(Guid id)
    {
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAppointemnt()
    {
        return NoContent();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAppointemnt(Guid id)
    {
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAppointment(Guid id){
        return NoContent();
    }
    
}