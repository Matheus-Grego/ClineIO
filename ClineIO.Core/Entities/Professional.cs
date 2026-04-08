using ClineIO.Core.Enums;

namespace ClineIO.Core.Entities;

public class Professional : Person
{
    protected Professional() : base() => AppointmentsAsProfessional = [];

    public Professional(string documentNumber, string fullname, string email, string phoneNumber, string zipCode, string passWord, string credential) : base(documentNumber, fullname, email, phoneNumber, zipCode, passWord)
    {
        Credential = credential;
        AppointmentsAsProfessional = [];
        Status = DoctorStatus.Available;
    }
    public string Credential { get; private set; }
    public DoctorStatus Status { get; private set; }
    public List<Appointment> AppointmentsAsProfessional { get; private set; }
    public List<TenentProfessional> Tenents { get; set; } = [];
}