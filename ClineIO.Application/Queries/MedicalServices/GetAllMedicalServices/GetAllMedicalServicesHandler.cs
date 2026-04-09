using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Queries.MedicalServices.GetAllMedicalServices;

public class GetAllMedicalServicesHandler : IRequestHandler<GetAllMedicalSerivcesQuery, Result<List<MedicalSerivceViewModel>>>
{
    private readonly IMedicalServiceRepository _repository;
    public GetAllMedicalServicesHandler(IMedicalServiceRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<List<MedicalSerivceViewModel>>> Handle(GetAllMedicalSerivcesQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAll();
        var medicalService = result.Select(category => MedicalSerivceViewModel.FromEntity(category)).ToList();
        return Result<List<MedicalSerivceViewModel>>.Success(medicalService);
    }
}