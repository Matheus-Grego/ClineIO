using ClineIO.Core.Entities;
using ClineIO.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ClineIO.Infrastructure.Repositories;

public class TenentRepository : ITenentRepository
{
    private readonly DbContextClineIO _context;
    public TenentRepository(DbContextClineIO dbContext)
    {
        _context = dbContext;
    }
    public async Task<List<Tenent?>> GetAll(int? pageNumber, int? pageSize, Guid? tenentId)
    {
        return await _context.Tenents.AsNoTracking()
            .Where(x => !x.IsDeleted)
            .Skip((pageNumber.Value - 1) * pageSize.Value)
            .Take(pageSize.Value)
            .ToListAsync();
    }

    public async Task<Tenent?> GetById(Guid id)
    {
        return await _context.Tenents
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task Add(Tenent entity)
    {
        await _context.Tenents.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Tenent entity)
    {
        _context.Tenents.Update(entity);
        await _context.SaveChangesAsync();
    }
}