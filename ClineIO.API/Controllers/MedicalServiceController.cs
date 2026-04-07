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
}