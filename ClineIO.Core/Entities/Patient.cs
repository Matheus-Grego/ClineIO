namespace ClineIO.Core.Entities;

public class Patient : Person
{
    public Patient(int documentNumber, string fullname, string email, int phoneNumber, string zipCode) : base(documentNumber, fullname, email, phoneNumber, zipCode)
    {
       
    }

    public List<Appointment> AppointmentsAsPatient { get; private set; }
}