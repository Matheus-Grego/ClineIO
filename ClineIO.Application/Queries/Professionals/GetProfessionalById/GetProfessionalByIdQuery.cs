using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Professionals.GetProfessionalById;

public class GetProfessionalByIdQuery : IRequest<Result<ProfessionalViewModel>>
{
    public GetProfessionalByIdQuery(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}