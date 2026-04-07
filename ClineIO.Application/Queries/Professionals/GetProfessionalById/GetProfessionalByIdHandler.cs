using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Queries.Professionals.GetProfessionalById;

public class GetProfessionalByIdHandler : IRequestHandler<GetProfessionalByIdQuery, Result<ProfessionalViewModel>>
{
    private readonly IProfessionalRepository _repository;
    public GetProfessionalByIdHandler(IProfessionalRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<ProfessionalViewModel>> Handle(GetProfessionalByIdQuery request, CancellationToken cancellationToken)
    {
       var result = await _repository.GetById(request.Id);
       if (result == null)
       {
           return Result<ProfessionalViewModel>.Failure("Professional not found");
       }
       var viewModel = ProfessionalViewModel.FromEntity(result);
       return Result<ProfessionalViewModel>.Success(viewModel);
    }
}