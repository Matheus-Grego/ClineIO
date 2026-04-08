namespace ClineIO.Core.Entities;

public class Tenent : BaseEntity
{
    public Tenent(
        string name,
        string address1,
        string? address2,
        string city,
        string state,
        string zipCode) : base()
    {
        Name = name;
        Address1 = address1;
        Address2 = address2;
        City = city;
        State = state;
        ZipCode = zipCode;
    } 
    public string Name { get; set; }
    public string Address1 { get; set; }
    public string? Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    
    public List<TenentProfessional> TenentProfessionals { get; set; } = [];
}