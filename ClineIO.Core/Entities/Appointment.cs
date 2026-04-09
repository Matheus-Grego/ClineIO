using ClineIO.Core.Enums;

namespace ClineIO.Core.Entities;

public class Appointment : BaseEntity
{
    protected Appointment(){}
    public Appointment(
        Guid patientId,
        Guid professionalId,
        Guid? tenentId,
        Guid medicalServiceCategoryId,
        DateTime startTime,
        DateTime endTime,
        decimal price,
        AppointmentModality modality,
        PaymentModality paymentModality,
        string? observation)
    {
        PatientID = patientId;
        ProfessionalId = professionalId;
        TenentId = tenentId;
        MedicalServiceCategoryId = medicalServiceCategoryId;
        StartTime = startTime.ToUniversalTime();
        EndTime = endTime.ToUniversalTime();
        Price = price;
        AppointmentModality = modality;
        PaymentModality = paymentModality;
        Status = ApointmentStatus.Scheduled;
        Observation = observation;
    }
    public Guid PatientID { get; private set; }
    public Patient Patient { get; private set; }
    public Guid ProfessionalId { get; private set; }
    public Professional Professional { get; private set; }
    public Guid? TenentId { get; private set; }
    public Tenent? Tenent { get; private set; }
    public DateTime EndTime { get; private set; }
    public DateTime StartTime { get; private set; } 
    public ApointmentStatus Status { get; private set; }
    public decimal Price { get; private set; }
    public PaymentModality PaymentModality { get; private set; }
    public Guid MedicalServiceCategoryId { get; private set; }
    public MedicalService MedicalServiceCategory { get; private set; } 
    public AppointmentModality AppointmentModality { get; private set; }
    public string? Observation { get; set; }
    public int? Rating { get; set; }
    public string? RatingNote { get; set; }
    
    public void CompleteAppointment()
    {
        Status = ApointmentStatus.Completed;
    }
    public void CancelAppointment()
    {
        Status = ApointmentStatus.Canceled;
    }
    public void RescheduleAppointment(DateTime beginTime, DateTime endTime)
    {
        StartTime = beginTime;
        EndTime = endTime;
        Status = ApointmentStatus.Rescheduled;
    }
}