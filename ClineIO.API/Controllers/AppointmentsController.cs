using ClineIO.Application.Commands.Appointment.CreateAppointment;
using ClineIO.Application.Commands.Appointment.DeleteAppointment;
using ClineIO.Application.Models;
using ClineIO.Application.Queries.Appointments;
using ClineIO.Application.Queries.Appointments.GetAllAppointments;
using ClineIO.Application.Queries.Appointments.GetAppointmentById;
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
    public async Task<IActionResult> GetAllTenentApointments([FromQuery]  GetAllAppointmentsQuery query)
    {
        var result = await _mediator.Send(query);
        if (!result.IsSuccess)
            return BadRequest();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAppointmentById(Guid id)
    {
        var result = await _mediator.Send(new GetAppointmentByIdQuery(id));
        if (!result.IsSuccess)
            return BadRequest();

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
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAppointment(Guid id)
    {

        var result = await _mediator.Send(new DeleteAppointmentCommand(id));
        if (!result.IsSuccess)
            return BadRequest();

        return NoContent();
    }
    
}