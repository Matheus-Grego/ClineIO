using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Commands.Appointment.DeleteAppointment;

public class DeleteAppointmentCommand : IRequest<Result>
{
    public DeleteAppointmentCommand(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}