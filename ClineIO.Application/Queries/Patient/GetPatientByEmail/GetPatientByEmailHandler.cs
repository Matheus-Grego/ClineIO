using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Queries.Patient.GetPatientByEmail;

public class GetPatientByEmailHandler : IRequestHandler<GetPatientByEmailQuery, Result<PatientViewModel>>
{
    private readonly IPatientRepository _repository;
    public GetPatientByEmailHandler(IPatientRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<PatientViewModel>> Handle(GetPatientByEmailQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetPatientByEmail(request.Email);
        var patient = PatientViewModel.FromEntity(result);
        if (result == null)
        {
            return Result<PatientViewModel>.Failure("Patient not found");
        }
        return Result<PatientViewModel>.Success(patient);
    }
}