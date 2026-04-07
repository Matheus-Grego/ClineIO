using ClineIO.Core.Enums;

namespace ClineIO.Core.Entities;

public class Professional : Person
{
    protected Professional() : base() => AppointmentsAsProfessional = [];

    public Professional(int documentNumber, string fullname, string email, int phoneNumber, string zipCode, string passWord) : base(documentNumber, fullname, email, phoneNumber, zipCode, passWord)
    {
        AppointmentsAsProfessional = [];
    }
    public string Credential { get; private set; }
    public DoctorStatus Status { get; private set; }
    public List<Appointment> AppointmentsAsProfessional { get; private set; }
    public List<Tenent> Tenents { get; set; }

}