namespace ClineIO.Core.Entities;

public class Patient : Person
{
    protected Patient(){}
    
    public Patient(string documentNumber, string fullname, string email, string phoneNumber, string zipCode, string passWord) : base(documentNumber, fullname, email, phoneNumber, zipCode, passWord)
    {
        AppointmentsAsPatient = new List<Appointment?>();
    }

    public List<Appointment?> AppointmentsAsPatient { get; private set; }
    
    public List<Appointment?> GetAppointmentHistory()
    {
        return AppointmentsAsPatient;
    }
}