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
    public async Task<IActionResult> AddMedicalService()
    {
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMedicalService(Guid id)
    {
        return NoContent();
    }
}