using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Commands.Patient.DeletePatient;

public class DeletePatientCommand : IRequest<Result>
{
    public DeletePatientCommand(Guid id)
    {
        PatientId = id;
    }
    public Guid PatientId { get; set; }
}