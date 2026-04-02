using Microsoft.EntityFrameworkCore;

namespace ClineIO.Infrastructure;

public class DbContextClineIO : DbContext
{
    public readonly DbContextOptions<DbContextClineIO> _dbContextOptions;

    public DbContextClineIO(DbContextOptions<DbContextClineIO> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        
    }

}