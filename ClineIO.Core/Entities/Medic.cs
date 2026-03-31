namespace ClineIO.Core.Entities;

public class Medic : Person
{
    public Medic(int cpf, string fullname, string email, int phoneNumber)
    {
        CPF = cpf;
        FullName = fullname;
        Email = email;
        PhoneNumber = phoneNumber;
    }
    public int Credential { get; set; }
}