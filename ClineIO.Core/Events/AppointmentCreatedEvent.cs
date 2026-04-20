namespace ClineIO.Core.Events;

public class AppointmentCreatedEvent
{
    public AppointmentCreatedEvent(Guid appointmentId, Guid patientId, Guid professionalId)
    {
        AppointmentId = appointmentId;
        PatientId = patientId;
        ProfessionalId = professionalId;
    }

    public Guid AppointmentId { get; private set; }
    public Guid PatientId { get; private set; }
    public Guid ProfessionalId { get; private set; }
}