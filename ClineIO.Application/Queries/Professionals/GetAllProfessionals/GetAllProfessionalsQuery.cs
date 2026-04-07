using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Professionals.GetAllProfessionals;

public class GetAllProfessionalsQuery : IRequest<Result<List<ProfessionalViewModel>>>
{
    public int? Page { get; set; }
    public int? PageSize { get; set; }
    public Guid? TenantId { get; set; }
}