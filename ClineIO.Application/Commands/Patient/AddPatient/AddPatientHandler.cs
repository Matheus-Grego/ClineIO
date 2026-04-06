using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Commands.Patient.AddPatient;

public class AddPatientHandler : IRequestHandler<AddPatientCommand, Result>
{
    private readonly IPatientRepository _repository;
    public AddPatientHandler(IPatientRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Result> Handle(AddPatientCommand request, CancellationToken cancellationToken)
    {
        var entity = request.ToEntity(); 
        await _repository.Add(entity); 
        return Result.Success;
    }
}