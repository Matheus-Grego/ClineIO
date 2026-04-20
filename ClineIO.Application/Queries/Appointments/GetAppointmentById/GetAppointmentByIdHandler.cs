using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Queries.Appointments.GetAppointmentById;

public class GetAppointmentByIdHandler : IRequestHandler<GetAppointmentByIdQuery, Result<AppointmentViewModel>>
{
    private readonly IAppointmentRepository _repository;
    public GetAppointmentByIdHandler(IAppointmentRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result<AppointmentViewModel>> Handle(GetAppointmentByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetById(request.Id);
        var appointment = AppointmentViewModel.FromEntity(result);
        if(result == null)
            return Result<AppointmentViewModel>.Failure("Patient not found");
        
        return Result<AppointmentViewModel>.Success(appointment);
    }
}