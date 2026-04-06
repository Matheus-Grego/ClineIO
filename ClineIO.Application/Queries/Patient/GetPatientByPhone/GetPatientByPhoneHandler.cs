using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Queries.Patient.GetPatientByPhone;

public class GetPatientByPhoneHandler : IRequestHandler<GetPatientByPhoneQuery, Result<PatientViewModel>>
{
    private readonly IPatientRepository _repository;
    public GetPatientByPhoneHandler(IPatientRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<PatientViewModel>> Handle(GetPatientByPhoneQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetPatientByPatientPhoneNumber(request.PhoneNumber);
        var patient = PatientViewModel.FromEntity(result);
        if(result == null)
            return Result<PatientViewModel>.Failure("Patient Not Found");
        
        return Result<PatientViewModel>.Success(patient);
    }
}