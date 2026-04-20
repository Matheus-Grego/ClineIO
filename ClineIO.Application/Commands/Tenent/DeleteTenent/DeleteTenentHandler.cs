using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Commands.Tenent.DeleteTenent;

public class DeleteTenentHandler : IRequestHandler<DeleteTenentCommand, Result>
{
    private readonly ITenentRepository _repository;
    public DeleteTenentHandler(ITenentRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(DeleteTenentCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id);
        result.DeleteTenent();
        _repository.Update(result);
        return Result.Success;
    }
}