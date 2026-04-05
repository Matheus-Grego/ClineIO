using ClineIO.Core.Entities;

namespace ClineIO.Application.Models;

public class PatientViewModel
{
    public PatientViewModel(string name, string email, int phone, string adddress)
    {
        Name = name;
        Email = email;
        PhoneNumber = phone;
        Address = adddress;
    }
    public string Name { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    
    public static PatientViewModel FromEntity(Patient patient) => new (patient.FullName, patient.Email, patient.PhoneNumber, patient.Address);
}
