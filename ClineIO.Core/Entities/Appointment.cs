namespace ClineIO.Core.Entities;

public class Appointment : BaseEntity
{
    public Guid PatientID { get; set; }
    public Patient Patient { get; set; }
    
    public Guid MedicId { get; set; }
    public Medic Medic { get; set; }
    
    public DateTime ApointmentDate { get; set; }
    public DateTime EndTime { get; set; }
    public DateTime StartTime { get; set; } 
}