using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Commands.Professional.AddProfessional;

public class AddProfessionalHandler : IRequestHandler<AddProfessionalCommand, Result>
{
    private readonly IPatientRepository _repository;
    public AddProfessionalHandler(IPatientRepository repository)
    {
        _repository = repository;
    }
    public Task<Result> Handle(AddProfessionalCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}