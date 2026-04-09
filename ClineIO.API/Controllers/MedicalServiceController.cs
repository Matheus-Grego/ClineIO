using ClineIO.Application.Commands.MedicalService.AddMedicalService;
using ClineIO.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClineIO.API.Controllers;

[ApiController]
[Route("api/medical-service")]
public class MedicalServiceController : ControllerBase
{
    private readonly IMediator _mediator;
    public MedicalServiceController(IMediator mediator)
    {
        _mediator = mediator;
    } 
    
    [HttpGet]
    public async Task<IActionResult> GetAllMedicalServices()
    {
        return NoContent();
    }
    
    [HttpPost]
    public async Task<IActionResult> AddMedicalService(AddMedicalServiceCommand command)
    {
        var result = await _mediator.Send(command);
        if(!result.IsSuccess)
            return BadRequest();
        return CreatedAtAction("AddMedicalService", result);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMedicalService(Guid id)
    {
        return NoContent();
    }
}