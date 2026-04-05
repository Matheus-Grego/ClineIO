using ClineIO.Application.Models;
using ClineIO.Core.Entities;
using MediatR;

namespace ClineIO.Application.Commands.Patient.AddPatient;

public class AddPatientCommand : IRequest<Result>
{
    public int DocumentNumber { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string ZipCode { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public char Gender { get; set; }
    
    public Core.Entities.Patient ToEntity() => new (DocumentNumber, FullName, Email, PhoneNumber, ZipCode);
}