using ClineIO.Application.Commands.Professional.AddProfessional;
using ClineIO.Application.Commands.Professional.DeleteProfessional;
using ClineIO.Application.Commands.Professional.UpdateProfessional;
using ClineIO.Application.Queries.Professionals.GetAllProfessionals;
using ClineIO.Application.Queries.Professionals.GetProfessionalById;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ClineIO.API.Controllers;

[ApiController]
[Route("api/professional")]
public class ProfessionalController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProfessionalController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet()]
    public async Task<IActionResult> GetAllProfessionals([FromQuery] GetAllProfessionalsQuery query)
    {
        var result = await _mediator.Send(query);
        if (!result.IsSuccess)
        {
            return BadRequest();
        }
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProfessionalById(Guid id)
    {
        var result = await _mediator.Send(new GetProfessionalByIdQuery(id));
        if (!result.IsSuccess)
        {
            return BadRequest();
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddProfessional(AddProfessionalCommand command)
    {
        var result = await _mediator.Send(command);
        if (!result.IsSuccess)
        {
            return BadRequest();
        }
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProfessional(Guid id,UpdateProfessionalCommand  command)
    {
        command.Id = id;
        var result = await _mediator.Send(command);
        if (!result.IsSuccess)
            return BadRequest();
        
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProfessional(Guid id)
    {
        var result = await _mediator.Send(new DeleteProfessionalCommand(id));
        if (!result.IsSuccess)
            return BadRequest();
        
        return NoContent();
    }
}