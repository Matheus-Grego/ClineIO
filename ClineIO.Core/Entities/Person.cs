namespace ClineIO.Core.Entities;

public class Person : BaseEntity
{
    public Person(int documentNumber, string fullname, string email, int phoneNumber, string zipCode)
    {
        DocumentNumber = documentNumber;
        FullName = fullname;
        Email = email;
        PhoneNumber = phoneNumber;
        ZipCode = ZipCode;
    }
    public int DocumentNumber { get; private set; }
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public int PhoneNumber { get; private set; }
    public string ZipCode { get; private set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
   
}