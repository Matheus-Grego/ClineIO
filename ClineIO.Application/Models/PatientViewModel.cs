using ClineIO.Core.Entities;

namespace ClineIO.Application.Models;

public class PatientViewModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public long PhoneNumber { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    
    public static PatientViewModel FromEntity(Patient patient) => 
        new PatientViewModel
        {
            Name = patient.FullName,
            Email = patient.Email,
            PhoneNumber = patient.PhoneNumber,
            Address = patient.Address,
            City = patient.City,
            State = patient.State,
            ZipCode = patient.ZipCode
        };
}
