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
    public async Task<List<Patient>> GetAll(int pageNumber = 0, int pageSize = 10)
    {
        return await _context.Patients.ToListAsync();
    }
    public async Task<Patient> GetById(Guid patientId)
    {
        return await _context.Patients.SingleOrDefaultAsync(p => p.Id == patientId);
    }
    public async Task<Patient> GetPatientByPatientPhoneNumber(long patientNumber)
    {
        return await _context.Patients.SingleOrDefaultAsync(p => p.PhoneNumber == patientNumber);
    }
    public async Task<Patient> GetPatientByEmail(string patientEmail)
    {
        return await _context.Patients.SingleOrDefaultAsync(p => p.Email == patientEmail);
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