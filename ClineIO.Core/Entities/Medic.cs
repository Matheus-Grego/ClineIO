namespace ClineIO.Core.Entities;

public class Medic : Person
{
    public Medic(int documentNumber, string fullname, string email, int phoneNumber)
    {
        DocumentNumber = documentNumber;
        FullName = fullname;
        Email = email;
        PhoneNumber = phoneNumber;
    }
    public int Credential { get; set; }
}