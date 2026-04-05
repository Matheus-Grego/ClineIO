using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Patient.GetPatientById;

public class GetPatientByIdQuery : IRequest<Result<PatientViewModel>>
{
    public GetPatientByIdQuery(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}