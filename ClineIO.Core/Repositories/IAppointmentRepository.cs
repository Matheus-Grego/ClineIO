using ClineIO.Core.Entities;

namespace ClineIO.Core.Repositories;

public interface IAppointmentRepository : IBaseRepository<Appointment>
{
    Task<Appointment> AddAppointment(Appointment appointment);
}