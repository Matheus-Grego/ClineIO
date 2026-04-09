using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Commands.MedicalService.AddMedicalService;

public class AddMedicalServiceHandler : IRequestHandler<AddMedicalServiceCommand, Result>
{
    private readonly IMedicalServiceRepository _repository;
    public AddMedicalServiceHandler(IMedicalServiceRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(AddMedicalServiceCommand request, CancellationToken cancellationToken)
    {
        var entity = request.ToEntity();
        await _repository.Add(entity);
        return Result.Success;
    }
}