using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Commands.MedicalService.AddMedicalService;

public class AddMedicalServiceCommand : IRequest<Result>
{
    public string Description { get; set; }
    
    public Core.Entities.MedicalService ToEntity() => new(Description);
}