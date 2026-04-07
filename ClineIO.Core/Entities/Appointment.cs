using ClineIO.Core.Enums;

namespace ClineIO.Core.Entities;

public class Appointment : BaseEntity
{
    protected Appointment(){}
    public Appointment(Guid patientId, Guid doctorId, DateTime apointmentDate, TimeOnly startTime, TimeOnly endTime)
    {
        PatientID = patientId;
        MedicId = doctorId;
        ApointmentDate = apointmentDate;
        StartTime = startTime;
        EndTime = endTime;
        Status = ApointmentStatus.Scheduled;
    }
    public Guid PatientID { get; private set; }
    public Patient Patient { get; private set; }
    public Guid MedicId { get; private set; }
    public Professional Professional { get; private set; }
    public DateTime ApointmentDate { get; private set; }
    public TimeOnly EndTime { get; private set; }
    public TimeOnly StartTime { get; private set; } 
    public ApointmentStatus Status { get; private set; }
    public Guid CategoryId { get; set; }
    public MedicalService Category { get; set; } 

    public void CompleteAppointment(Appointment appointment)
    {
        appointment.Status = ApointmentStatus.Completed;
    }

    public void CancelAppointment(Appointment appointment)
    {
        appointment.Status = ApointmentStatus.Canceled;
    }
}