using ClineIO.Core.Entities;
using ClineIO.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ClineIO.Infrastructure.Repositories;

public class ProfessionalRepository : IProfessionalRepository
{
    private readonly DbContextClineIO _context;
    public ProfessionalRepository(DbContextClineIO dbContext)
    {
        _context = dbContext;
    }
    public async Task<List<Professional?>> GetAll(int? pageNumber, int? pageSize, Guid? tenentId)
    {
        return await _context.Professionals.AsNoTracking()
            .Where(x => !x.IsDeleted && (!tenentId.HasValue || x.Tenents.Any(y => y.TenentId == tenentId.Value)))
            .Skip((pageNumber.Value - 1) * pageSize.Value)
            .Take(pageSize.Value)
            .ToListAsync();
    }

    public async Task<Professional?> GetById(Guid id)
    {
        return await _context.Professionals
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task Add(Professional entity)
    {
        await _context.Professionals.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Professional entity)
    {
        _context.Professionals.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<Professional?> GetProfessionalByPhone(long patientNumber)
    {
        return await _context.Professionals.AsNoTracking()
            .SingleOrDefaultAsync(x => x.PhoneNumber == patientNumber);
    }

    public async Task<Professional?> GetProfessionalByEmail(string patientEmail)
    {
        return await _context.Professionals.AsNoTracking()
            .SingleOrDefaultAsync(x => x.Email == patientEmail);
    }

    public async Task<Professional?> GetProfessionalByCredential(string credentialNumber)
    {
        return await _context.Professionals.AsNoTracking()
            .SingleOrDefaultAsync(x => x.Credential == credentialNumber);
    }
}