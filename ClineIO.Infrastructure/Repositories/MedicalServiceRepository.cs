using ClineIO.Core.Entities;
using ClineIO.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ClineIO.Infrastructure.Repositories;

public class MedicalServiceRepository : IMedicalServiceRepository
{
    private readonly DbContextClineIO _context;
    public MedicalServiceRepository(DbContextClineIO dbContext)
    {
        _context = dbContext;
    }
    public async Task<List<MedicalService?>> GetAll(int? pageNumber, int? pageSize, Guid? tenentId)
    {
        return await _context.MedicalServices.ToListAsync();
    }

    public async Task<MedicalService?> GetById(Guid id)
    {
        return await _context.MedicalServices.SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task Add(MedicalService entity)
    {
        await _context.MedicalServices.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(MedicalService entity)
    {
        _context.MedicalServices.Update(entity);
        await _context.SaveChangesAsync();
    }
}
