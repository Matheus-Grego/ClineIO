namespace ClineIO.Core.Entities;

public class Patient : Person
{
    public Patient(int cpf, string fullname, string email, int phoneNumber)
    {
        CPF = cpf;
        FullName = fullname;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public List<Appointment> appointments { get; set; }
}