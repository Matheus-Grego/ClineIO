using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Tenents.GetTenentById;

public class GetTenentByIdQuery : IRequest<Result<TenentViewModel>>
{
    public GetTenentByIdQuery(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}