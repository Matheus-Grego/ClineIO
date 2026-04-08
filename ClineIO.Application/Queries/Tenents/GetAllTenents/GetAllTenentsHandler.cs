using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Queries.Tenents.GetAllTenents;

public class GetAllTenentsHandler : IRequestHandler<GetAllTenentsQuery, Result<List<TenentViewModel>>>
{
    private readonly ITenentRepository _repository;
    public GetAllTenentsHandler(ITenentRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<List<TenentViewModel>>> Handle(GetAllTenentsQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAll(request.Page, request.PageSize, null);
        var viewModel = result.Select(x => TenentViewModel.FromEntity(x)).ToList();
        return Result<List<TenentViewModel>>.Success(viewModel);
    }
}