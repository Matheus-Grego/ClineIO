using ClineIO.Core.Entities;
using ClineIO.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ClineIO.Infrastructure.Repositories;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly DbContextClineIO _context;
    public AppointmentRepository(DbContextClineIO dbContext)
    {
        _context = dbContext;
    }
    public async Task<List<Appointment?>> GetAll(int? pageNumber, int? pageSize, Guid? tenentId)
    {
        return await _context.Appointments.AsNoTracking()
            .Where(x => !x.IsDeleted)
            .Skip((pageNumber.Value - 1) * pageSize.Value)
            .Take(pageSize.Value)
            .ToListAsync();
    }

    public async Task<Appointment?> GetById(Guid id)
    {
        return await _context.Appointments.SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task Add(Appointment entity)
    {
        await _context.Appointments.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Appointment entity)
    {
        _context.Appointments.Update(entity);
        await _context.SaveChangesAsync();
    }
}