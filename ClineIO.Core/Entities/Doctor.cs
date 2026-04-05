using ClineIO.Core.Enums;

namespace ClineIO.Core.Entities;

public class Doctor : Person
{
    protected Doctor() : base() => AppointmentsAsDoctor = [];

    public Doctor(int documentNumber, string fullname, string email, int phoneNumber, string zipCode) : base(documentNumber, fullname, email, phoneNumber, zipCode)
    {
        AppointmentsAsDoctor = [];
    }
    public int Credential { get; private set; }
    public DoctorStatus Status { get; private set; }
    public List<Appointment> AppointmentsAsDoctor { get; private set; }
}