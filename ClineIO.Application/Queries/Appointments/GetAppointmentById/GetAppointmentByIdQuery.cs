using ClineIO.Application.Models;
using MediatR;

namespace ClineIO.Application.Queries.Appointments.GetAppointmentById;

public class GetAppointmentByIdQuery : IRequest<Result<AppointmentViewModel>>
{
    public GetAppointmentByIdQuery(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; private set; }
}