namespace ClineIO.Core.Entities;

public class Patient : Person
{
    protected Patient(){}
    
    public Patient(long documentNumber, string fullname, string email, long phoneNumber, string zipCode, string passWord) : base(documentNumber, fullname, email, phoneNumber, zipCode, passWord)
    {
        AppointmentsAsPatient = new List<Appointment?>();
    }

    public List<Appointment?> AppointmentsAsPatient { get; private set; }
}