using ClineIO.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClineIO.Infrastructure;

public class DbContextClineIO : DbContext
{
    public readonly DbContextOptions<DbContextClineIO> _dbContextOptions;

    public DbContextClineIO(DbContextOptions<DbContextClineIO> options) : base(options)
    {
        
    }
    
    public DbSet<Appointment>  Appointments { get; set; }
    public DbSet<Doctor>  Medics { get; set; }
    public DbSet<Patient>  Patients { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Appointment>(e =>
        {
            e.HasKey(u => u.Id);

            e.HasOne(p => p.Patient)
                .WithMany(a => a.AppointmentsAsPatient);

            e.HasOne(m => m.Doctor).WithMany(m => m.AppointmentsAsDoctor);
        });
    }

}