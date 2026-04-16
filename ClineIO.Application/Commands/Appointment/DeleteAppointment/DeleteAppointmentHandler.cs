using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using ClineIO.Infrastructure.GoogleCalendar;
using MediatR;

namespace ClineIO.Application.Commands.Appointment.DeleteAppointment;

public class DeleteAppointmentHandler : IRequestHandler<DeleteAppointmentCommand, Result>
{
    private readonly IAppointmentRepository _repository;
    public DeleteAppointmentHandler(IAppointmentRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(DeleteAppointmentCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id);
        result.CancelAppointment();
        _repository.Update(result);
        return Result.Success;
    }
}