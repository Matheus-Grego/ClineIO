namespace ClineIO.Core.Entities;

public class Patient : Person
{
    public Patient(int documentNumber, string fullname, string email, int phoneNumber)
    {
        DocumentNumber = documentNumber;
        FullName = fullname;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public List<Appointment> appointments { get; set; }
}