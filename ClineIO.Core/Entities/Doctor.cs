namespace ClineIO.Core.Entities;

public class Doctor : Person
{
    public Doctor(int documentNumber, string fullname, string email, int phoneNumber, string zipCode) : base(documentNumber, fullname, email, phoneNumber, zipCode)
    {
        
    }
    public int Credential { get; private set; }
    public List<Appointment> AppointmentsAsDoctor { get; private set; }
}