using ClineIO.Application.Models;
using ClineIO.Core.Enums;
using MediatR;

namespace ClineIO.Application.Queries.Appointments.GetAllAppointments;

public class GetAllAppointmentsQuery : IRequest<Result<List<AppointmentViewModel>>>
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public Guid TenentId { get; set; }
}

