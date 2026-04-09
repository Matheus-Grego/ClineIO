using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using ClineIO.Infrastructure.GoogleCalendar;
using MediatR;

namespace ClineIO.Application.Commands.Appointment.CreateAppointment;

public class CreateAppointmentHandler : IRequestHandler<CreateAppointmentCommand, Result>
{
    private readonly IAppointmentRepository _repository;
    private readonly IGoogleCalendarService _calendarService;
    public CreateAppointmentHandler(IAppointmentRepository repository, IGoogleCalendarService calendarService)
    {
        _repository = repository;
        _calendarService = calendarService;
    }
    public async Task<Result> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
    {
        var entity = request.ToEntity();
        var details = await _repository.AddAppointment(entity);
        
        await _calendarService.CreateEventAsync($"Consulta {details.MedicalServiceCategory.Description}",details.StartTime, details.EndTime,
            details.Patient.Email, details.Professional.Email);
        return Result.Success;
    }
}