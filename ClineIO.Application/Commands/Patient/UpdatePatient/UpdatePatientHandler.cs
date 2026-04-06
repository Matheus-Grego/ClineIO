using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClineIO.Application.Commands.Patient.UpdatePatient;

public class UpdatePatientHandler : IRequestHandler<UpdatePatientCommand, Result>
{
    private readonly IPatientRepository _repository;
    public UpdatePatientHandler(IPatientRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id);
        if (result == null)
        {
            return Result.Failure("User not found");
        }
        var person = request.ToEntity();
        result.UpdateUser(person);
        await _repository.Update(result);
        
        return Result.Success;
    }
}