using ClineIO.Application.Commands.Tenent.AddTenent;
using ClineIO.Application.Queries.Professionals.GetAllProfessionals;
using ClineIO.Application.Queries.Tenents.GetAllTenents;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClineIO.API.Controllers;

[ApiController]
[Route("api/clinic")]
public class TenentController : ControllerBase
{
    private readonly IMediator _mediator;
    public TenentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTenents([FromQuery] GetAllTenentsQuery query)
    {
        var result = await _mediator.Send(query);
        if (!result.IsSuccess)
            return BadRequest();
        return Ok(result);    
    }

    [HttpPost]
    public async Task<IActionResult> AddTenent(AddTenentCommand command)
    {
         var result = await _mediator.Send(command);
         if(!result.IsSuccess)
             return BadRequest();
         
         return NoContent();
        
    }
    
}