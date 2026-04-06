using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Commands.Patient.DeletePatient;

public class DeletePatientHandler : IRequestHandler<DeletePatientCommand, Result>
{
    private readonly IPatientRepository _repository;
    public DeletePatientHandler(IPatientRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.PatientId);
        if (result == null)
        {
            return Result.Failure("User not found");
        }
        result.DeleteUser();
        await _repository.Update(result);
        return Result.Success;
    }
}