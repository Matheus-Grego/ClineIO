using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Commands.Tenent.AddTenent;

public class AddTenentHandler : IRequestHandler<AddTenentCommand, Result>
{
    private readonly ITenentRepository _repository;
    public AddTenentHandler(ITenentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result> Handle(AddTenentCommand request, CancellationToken cancellationToken)
    {
        var entity = request.ToEntity(); 
        await _repository.Add(entity); 
        return Result.Success;
    }
}