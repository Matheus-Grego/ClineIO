using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ClineIO.Application.Queries.Professionals.GetAllProfessionals;

public class GetAllProfessionalsHandler : IRequestHandler<GetAllProfessionalsQuery, Result<List<ProfessionalViewModel>>>
{
    private readonly IProfessionalRepository _repository;
    public GetAllProfessionalsHandler(IProfessionalRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<List<ProfessionalViewModel>>> Handle(GetAllProfessionalsQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAll(request.Page, request.PageSize, request.TenantId);
        var viewModel = result.Select(x => ProfessionalViewModel.FromEntity(x)).ToList();
        return Result<List<ProfessionalViewModel>>.Success(viewModel);
    }
}