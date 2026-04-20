using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Queries.Appointments.GetAllAppointments;

public class GetAllAppointmentsHandler : IRequestHandler<GetAllAppointmentsQuery, Result<List<AppointmentViewModel>>>
{
    private readonly IAppointmentRepository _repository;
    public GetAllAppointmentsHandler(IAppointmentRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<List<AppointmentViewModel>>> Handle(GetAllAppointmentsQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAll(request.Page, request.PageSize, request.TenentId);
        var appointments = result.Select(appointment => AppointmentViewModel.FromEntity(appointment)).ToList();
        return Result<List<AppointmentViewModel>>.Success(appointments);
    }
}