namespace ClineIO.Core.Entities;

public class Appointment : BaseEntity
{
    public Guid PatientID { get; private set; }
    public Patient Patient { get; private set; }
    public Guid MedicId { get; private set; }
    public Doctor Doctor { get; private set; }
    public DateTime ApointmentDate { get; private set; }
    public DateTime EndTime { get; private set; }
    public DateTime StartTime { get; private set; } 
}