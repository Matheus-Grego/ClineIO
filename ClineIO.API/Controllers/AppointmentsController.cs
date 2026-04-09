using ClineIO.Application.Commands.Appointment.CreateAppointment;
using ClineIO.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClineIO.API.Controllers;

[ApiController]
[Route("api/appointments")]
public class AppointmentsController : ControllerBase
{
    private readonly IMediator _mediator;
    public AppointmentsController(IMediator mediator)
    {
        _mediator = mediator;
    }
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
    public async Task<IActionResult> CreateAppointemnt(CreateAppointmentCommand command)
    {
        var result = await _mediator.Send(command);
        if (!result.IsSuccess)
            return BadRequest();

        return Ok(result);
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