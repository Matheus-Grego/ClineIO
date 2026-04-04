namespace ClineIO.Core.Entities;

public class Patient : Person
{
    protected Patient() : base()
    {
        AppointmentsAsPatient = [];
    }
    
    public Patient(int documentNumber, string fullname, string email, int phoneNumber, string zipCode) : base(documentNumber, fullname, email, phoneNumber, zipCode)
    {
        AppointmentsAsPatient = [];
    }

    public List<Appointment> AppointmentsAsPatient { get; private set; }
}