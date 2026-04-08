using ClineIO.Application.Models;
using ClineIO.Core.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ClineIO.Application.Commands.Patient.AddPatient;

public class AddPatientCommand : IRequest<Result>
{
    public string DocumentNumber { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string ZipCode { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public char Gender { get; set; }
    public string Password { get; set; }
    
    public Core.Entities.Patient ToEntity() => new (DocumentNumber, FullName, Email, PhoneNumber, ZipCode, Password);
}