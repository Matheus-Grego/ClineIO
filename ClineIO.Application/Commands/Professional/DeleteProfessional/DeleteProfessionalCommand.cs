using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Commands.Professional.DeleteProfessional;

public class DeleteProfessionalCommand : IRequest<Result>
{
    public DeleteProfessionalCommand(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}