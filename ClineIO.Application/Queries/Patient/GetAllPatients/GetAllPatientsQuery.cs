using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Patient.GetAllPatients;

public class GetAllPatientsQuery : IRequest<Result<PatientViewModel>>
{
    public int Page { get; set; }
    public int PageSize { get; set; }
}