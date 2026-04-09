using ClineIO.Application.Models;
using ClineIO.Core.Enums;
using MediatR;

namespace ClineIO.Application.Commands.Appointment.CreateAppointment;

public class CreateAppointmentCommand : IRequest<Result>
{
    public Guid PatientID { get; set; }
    public Guid ProfessionalId { get; set; }
    public Guid? TenentId { get; set; }
    public DateOnly ApointmentDate { get; set; }
    public TimeOnly EndTime { get; set; }
    public TimeOnly StartTime { get; set; } 
    public decimal Price { get; set; }
    public PaymentModality PaymentModality { get; set; }
    public Guid MedicalServiceCategoryId { get; set; }
    public AppointmentModality AppointmentModality { get; set; }
    public string? Observation { get; set; }
    
    public Core.Entities.Appointment ToEntity() => new(
        PatientID,
        ProfessionalId,
        TenentId,
        MedicalServiceCategoryId,
        ApointmentDate,
        StartTime,
        EndTime,
        Price,
        AppointmentModality,
        PaymentModality,
        Observation
    );}