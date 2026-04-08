using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Patient.GetPatientByPhone;

public class GetPatientByPhoneQuery : IRequest<Result<PatientViewModel>>
{
    public GetPatientByPhoneQuery(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }
    public string PhoneNumber { get; set; }
}