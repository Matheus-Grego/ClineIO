namespace ClineIO.Core.Entities;

public class Person : BaseEntity
{
   
    public int CPF { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
}