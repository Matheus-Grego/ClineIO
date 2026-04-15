using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Commands.MedicalService.DeleteMedicalService;

public class DeleteMedicalSerivceCommand : IRequest<Result>
{
    public DeleteMedicalSerivceCommand(Guid id)
    {
        Id = id;   
    }
    public Guid Id { get; set; }
}