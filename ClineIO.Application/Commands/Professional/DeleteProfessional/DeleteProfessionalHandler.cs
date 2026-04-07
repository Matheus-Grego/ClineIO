using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Commands.Professional.DeleteProfessional;

public class DeleteProfessionalHandler : IRequestHandler<DeleteProfessionalCommand, Result>
{
    private readonly IProfessionalRepository _repository;
    public DeleteProfessionalHandler(IProfessionalRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(DeleteProfessionalCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id);
        if(result == null)
            return Result.Failure("User not found");
        
        result.DeleteUser();
        await _repository.Update(result);
        return Result.Success;

    }
}