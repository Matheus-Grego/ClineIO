namespace ClineIO.Core.Entities;

public class Person : BaseEntity
{
    protected Person() { }
    public Person(string documentNumber, string fullname, string email, string phoneNumber, string zipCode, string password)
    {
        DocumentNumber = documentNumber;
        FullName = fullname;
        Email = email;
        PhoneNumber = phoneNumber;
        ZipCode = zipCode;
        Password = password;
    }
    public string DocumentNumber { get; private set; }
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public string ZipCode { get; private set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string Password { get; set; }
   
    public void DeleteUser()
    {
        IsDeleted = true;
    }
    
    public void UpdateUser(Person  person)
    {
        FullName = person.FullName;
        Email = person.Email;
        PhoneNumber = person.PhoneNumber;
        ZipCode = person.ZipCode;
        Address = person.Address;
        City = person.City;
    }
   
}