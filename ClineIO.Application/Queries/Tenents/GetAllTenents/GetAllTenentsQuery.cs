using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Tenents.GetAllTenents;

public class GetAllTenentsQuery : IRequest<Result<List<TenentViewModel>>>
{
    public int Page { get; set; }
    public int PageSize { get; set; }
}