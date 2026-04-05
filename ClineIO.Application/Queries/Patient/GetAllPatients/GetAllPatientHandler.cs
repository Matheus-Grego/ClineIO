using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Queries.Patient.GetAllPatients;

public class GetAllPatientHandler : IRequestHandler<GetAllPatientsQuery, Result<List<PatientViewModel?>>>
{
    private readonly IPatientRepository _repository;
    public GetAllPatientHandler(IPatientRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Result<List<PatientViewModel?>>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAllPatients(request.Page, request.PageSize);
        var patients = result.Select(patient => PatientViewModel.FromEntity(patient)).ToList();
        return Result<List<PatientViewModel>>.Success(patients);
    }
}