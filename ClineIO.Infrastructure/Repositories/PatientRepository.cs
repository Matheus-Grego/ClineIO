using ClineIO.Core.Entities;
using ClineIO.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ClineIO.Infrastructure.Repositories;

public class PatientRepository : IPatientRepository
{
    private readonly DbContextClineIO _context;
    public PatientRepository(DbContextClineIO dbContext)
    {
        _context = dbContext;
    }
    public async Task<List<Patient?>> GetAll(int? pageNumber = 0, int? pageSize = 10, Guid? tenentId = null)
    {
        return await _context.Patients.AsNoTracking()
            .Where(x => !x.IsDeleted)
            .Skip((pageNumber.Value - 1) * pageSize.Value)
            .Take(pageSize.Value)
            .ToListAsync();
    }
    public async Task<Patient?> GetById(Guid patientId)
    {
        return await _context.Patients.AsNoTracking()
            .SingleOrDefaultAsync(p => p.Id == patientId);
    }
    public async Task<Patient?> GetPatientByPatientPhoneNumber(string patientNumber)
    {
        return await _context.Patients.AsNoTracking()
            .SingleOrDefaultAsync(p => p.PhoneNumber == patientNumber);
    }
    public async Task<Patient?> GetPatientByEmail(string patientEmail)
    {
        return await _context.Patients.AsNoTracking()
            .SingleOrDefaultAsync(p => p.Email == patientEmail);
    }
    public async Task Add(Patient patient)
    {
        await _context.Patients.AddAsync(patient);
        await _context.SaveChangesAsync();
    }
    public async Task Update(Patient patient)
    {
         _context.Patients.Update(patient);
         await _context.SaveChangesAsync();
    }
}