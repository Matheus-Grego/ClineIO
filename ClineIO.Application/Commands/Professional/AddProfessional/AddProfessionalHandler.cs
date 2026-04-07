using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using ClineIO.Infrastructure.Auth;
using MediatR;

namespace ClineIO.Application.Commands.Professional.AddProfessional;

public class AddProfessionalHandler : IRequestHandler<AddProfessionalCommand, Result>
{
    private readonly IProfessionalRepository _repository;
    public AddProfessionalHandler(IProfessionalRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(AddProfessionalCommand request, CancellationToken cancellationToken)
    {
        request.Password = PasswordHash.HashPassword(request.Password);
        var entity = request.ToEntity;
        await _repository.Add(entity);
        return Result.Success;
    }
}