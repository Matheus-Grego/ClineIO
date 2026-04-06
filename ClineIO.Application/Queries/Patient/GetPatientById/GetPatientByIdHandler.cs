using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Queries.Patient.GetPatientById;

public class GetPatientByIdHandler : IRequestHandler<GetPatientByIdQuery, Result<PatientViewModel>>
{
    private readonly IPatientRepository _repository;
    public GetPatientByIdHandler(IPatientRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<PatientViewModel>> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id);
        var patient = PatientViewModel.FromEntity(result);
        if(result == null)
            return Result<PatientViewModel>.Failure("Patient not found");
        
        return Result<PatientViewModel>.Success(patient);
    }
}