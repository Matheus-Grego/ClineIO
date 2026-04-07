using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Professionals.GetAllProfessionals;

public class GetAllProfessionalsQuery : IRequest<Result<List<ProfessionalViewModel>>>
{
    
}