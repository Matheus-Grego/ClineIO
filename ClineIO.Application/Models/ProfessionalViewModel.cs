using ClineIO.Core.Entities;

namespace ClineIO.Application.Models;

public class ProfessionalViewModel
{
    public string Name { get; set; }
    public string Credential { get; set; }
    public string Email { get; set; }
    public long PhoneNumber { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }


    public static ProfessionalViewModel FromEntity(Professional professional) =>
        new ProfessionalViewModel
        {
            Name = professional.FullName,
            Credential = professional.Credential,
            Email = professional.Email,
            PhoneNumber = professional.PhoneNumber,
            Address = professional.Address,
            City = professional.City,
            State = professional.State,
            ZipCode = professional.ZipCode,
        };
}