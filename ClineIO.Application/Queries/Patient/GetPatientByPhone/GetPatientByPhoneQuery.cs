using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Patient.GetPatientByPhone;

public class GetPatientByPhoneQuery : IRequest<Result<PatientViewModel>>
{
    public GetPatientByPhoneQuery(long phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }
    public long PhoneNumber { get; set; }
}