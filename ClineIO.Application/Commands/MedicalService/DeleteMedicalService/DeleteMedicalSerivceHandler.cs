using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Commands.MedicalService.DeleteMedicalService;

public class DeleteMedicalSerivceHandler : IRequestHandler<DeleteMedicalSerivceCommand, Result>
{
    private readonly IMedicalServiceRepository _repository;
    public DeleteMedicalSerivceHandler(IMedicalServiceRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(DeleteMedicalSerivceCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id);
        result.DisableMedicalService();
        await _repository.Update(result);
        return Result.Success;
        
    }
}