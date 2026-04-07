using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Commands.Professional.UpdateProfessional;

public class UpdateProfessionalHandler : IRequestHandler<UpdateProfessionalCommand, Result>
{
    private readonly IProfessionalRepository _repository;
    public UpdateProfessionalHandler(IProfessionalRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result> Handle(UpdateProfessionalCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id);
        if (result == null)
        {
            return Result.Failure("Professional not found");
        }
        var person = request.ToEntity();
        result.UpdateUser(person);
        await _repository.Update(result);
        
        return Result.Success;
    }
}