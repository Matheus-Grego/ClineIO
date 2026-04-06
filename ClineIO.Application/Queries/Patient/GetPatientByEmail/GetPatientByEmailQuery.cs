using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Patient.GetPatientByEmail;

public class GetPatientByEmailQuery : IRequest<Result<PatientViewModel>>
{
    public GetPatientByEmailQuery(string email)
    {
        Email = email;
    }
    public string Email { get; set; }
}