using ClineIO.Application.Commands.MedicalService.AddMedicalService;
using ClineIO.Application.Commands.MedicalService.DeleteMedicalService;
using ClineIO.Application.Queries.MedicalServices.GetAllMedicalServices;
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
        var result = await _mediator.Send(new GetAllMedicalSerivcesQuery());
        return Ok(result);
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
        var result = await _mediator.Send(new DeleteMedicalSerivceCommand(id));
        if(!result.IsSuccess)
            return BadRequest();
        return NoContent();
    }
}