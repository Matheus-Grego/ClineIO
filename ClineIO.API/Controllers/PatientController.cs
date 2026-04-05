using ClineIO.Application.Commands.Patient.AddPatient;
using ClineIO.Application.Queries.Patient.GetAllPatients;
using ClineIO.Application.Queries.Patient.GetPatientById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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
    public async Task<IActionResult> GetAllPatients(GetAllPatientsQuery request)
    {
        var result = _mediator.Send(request);
        if (result == null)
        {
            return BadRequest();
        }
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPatientById(Guid id)
    {
        var result = _mediator.Send(new GetPatientByIdQuery(id));
        if (result == null)
        {
            return BadRequest();
        }
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddPatient(AddPatientCommand request)
    {
        var result = _mediator.Send(request);
        if (result == null)
        {
            return BadRequest();
        }
        return Ok(result);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePatient(Guid id)
    {
        return NoContent();
    }
    
}