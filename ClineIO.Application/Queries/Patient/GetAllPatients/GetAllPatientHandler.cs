using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Patient.GetAllPatients;

public class GetAllPatientHandler : IRequestHandler<GetAllPatientsQuery, Result<PatientViewModel>>
{
    
    public Task<Result<PatientViewModel>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}