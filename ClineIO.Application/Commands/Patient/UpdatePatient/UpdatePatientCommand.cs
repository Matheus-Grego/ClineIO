using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Commands.Patient.UpdatePatient;

public class UpdatePatientCommand : IRequest<Result>
{
    public UpdatePatientCommand(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
    public long DocumentNumber { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string ZipCode { get; set; }
    public string Email { get; set; }
    public long PhoneNumber { get; set; }
    public char Gender { get; set; }
    public string Password { get; set; }
    
    public Core.Entities.Person ToEntity() => new (DocumentNumber, FullName, Email, PhoneNumber, ZipCode,Password);
}
