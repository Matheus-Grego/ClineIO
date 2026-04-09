using ClineIO.Application.Models;
using ClineIO.Core.Repositories;
using MediatR;

namespace ClineIO.Application.Commands.Appointment.CreateAppointment;

public class CreateAppointmentHandler : IRequestHandler<CreateAppointmentCommand, Result>
{
    private readonly IAppointmentRepository _repository;
    public CreateAppointmentHandler(IAppointmentRepository repository)
    {
        _repository = repository;
    }
    public async Task<Result> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
    {
        var entity = request.ToEntity();
        await _repository.Add(entity);
        return Result.Success;
    }
}