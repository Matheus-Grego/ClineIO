using ClineIO.Core.Entities;
using ClineIO.Core.Enums;

namespace ClineIO.Application.Models;

public class AppointmentViewModel
{
    public AppointmentViewModel(string patientName,
        string professionalName,
        string patientDocument,
        string tenentName,
        DateTime startTime,
        DateTime endTime,
        decimal price,
        PaymentModality paymentModality,
        string medicalService,
        AppointmentModality appointmentModality,
        string? observation)
    {
        PatientName = patientName;
        ProfessionalName = professionalName;
        PatientDocument = patientDocument;
        TenentName = tenentName;
        StartTime = startTime;
        EndTime = endTime;
        Price = price;
        PaymentModality = paymentModality;
        MedicalService = medicalService;
        AppointmentModality = appointmentModality;
        Observation = observation;
    }

    public string PatientName { get; private set; }
    public string ProfessionalName { get; private set; }  
    public string PatientDocument { get; private set; } 
    public string TenentName { get; private set; }  
    public DateTime StartTime { get; private set; } 
    public DateTime EndTime { get; private set; }
    public decimal Price { get; private set; }
    public PaymentModality PaymentModality { get; private set; }
    public string MedicalService { get; private set; } 
    public AppointmentModality AppointmentModality { get; private set; }
    public string? Observation { get; set; }

    public static AppointmentViewModel FromEntity(Appointment appointment) =>
        new AppointmentViewModel(appointment.Patient.FullName,
            appointment.Professional.FullName,
            appointment.Patient.DocumentNumber,
            appointment.Tenent.Name,
            appointment.StartTime,
            appointment.EndTime,
            appointment.Price,
            appointment.PaymentModality,
            appointment.MedicalServiceCategory.Description,
            appointment.AppointmentModality,
            appointment?.Observation
        );
}