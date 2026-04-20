using ClineIO.Application.Models;
using ClineIO.Core.Entities;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Queries.Tenents.GetTenentById;

public class GetTenentByIdHandler : IRequestHandler<GetTenentByIdQuery, Result<TenentViewModel>>
{
    private readonly ITenentRepository _repository;
    public GetTenentByIdHandler(ITenentRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Result<TenentViewModel>> Handle(GetTenentByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id);
        var tenent = TenentViewModel.FromEntity(result);
        if(result == null)
            return Result<TenentViewModel>.Failure("Hospital not found");
        
        return Result<TenentViewModel>.Success(tenent);
        
    }
}