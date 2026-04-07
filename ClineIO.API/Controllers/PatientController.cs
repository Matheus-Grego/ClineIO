using ClineIO.Application.Commands.Patient.AddPatient;
using ClineIO.Application.Commands.Patient.DeletePatient;
using ClineIO.Application.Commands.Patient.UpdatePatient;
using ClineIO.Application.Queries.Patient.GetAllPatients;
using ClineIO.Application.Queries.Patient.GetPatientByEmail;
using ClineIO.Application.Queries.Patient.GetPatientById;
using ClineIO.Application.Queries.Patient.GetPatientByPhone;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace ClineIO.API.Controllers;

[ApiController]
[Route("api/patient")]
public class PatientController : ControllerBase
{
    private readonly IMediator _mediator;
    public PatientController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllPatients([FromQuery]  GetAllPatientsQuery query)
    {
        var result = await _mediator.Send(query);
        if (!result.IsSuccess)
        {
            return BadRequest();
        }
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPatientById(Guid id)
    {
        var result = await _mediator.Send(new GetPatientByIdQuery(id));
        if (!result.IsSuccess)
        {
            return BadRequest();
        }
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddPatient([FromBody] AddPatientCommand request)
    {
        var result = await _mediator.Send(request);
        if (!result.IsSuccess)
        {
            return BadRequest();
        }
        return NoContent();
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePatient(Guid id, UpdatePatientCommand request)
    {
        request.Id = id;
        var result = await _mediator.Send(request);
        if(!result.IsSuccess){
            return BadRequest();
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePatient(Guid id)
    {
        var result = await _mediator.Send(new DeletePatientCommand(id));
        if (!result.IsSuccess)
        {
            return BadRequest();
        }
        return NoContent();
    }

    [HttpGet("email")]
    public async Task<IActionResult> GetPatientByEmail([FromQuery] string email)
    {
        var result = await _mediator.Send(new GetPatientByEmailQuery(email));
        if (!result.IsSuccess)
        {
            return BadRequest();
        }
        return Ok(result);
    }
    [HttpGet("phonenumber")]
    public async Task<IActionResult> GetPatientByPhoneNumber([FromQuery] long PhoneNumber)
    {
        var result = await _mediator.Send(new GetPatientByPhoneQuery(PhoneNumber));
        if (!result.IsSuccess)
        {
            return BadRequest();
        }
        return Ok(result);
    }
    
}