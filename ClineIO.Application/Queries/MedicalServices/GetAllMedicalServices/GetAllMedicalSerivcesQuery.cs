using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.MedicalServices.GetAllMedicalServices;

public class GetAllMedicalSerivcesQuery : IRequest<Result<List<MedicalSerivceViewModel>>>
{
    
}