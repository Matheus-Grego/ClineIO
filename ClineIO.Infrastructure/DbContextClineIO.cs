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
    public DbSet<Nurse>  Nurses { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Appointment>(e =>
        {
            e.HasKey(u => u.Id);

            e.HasOne(a => a.Patient)
                .WithMany(p => p.AppointmentsAsPatient)
                .HasForeignKey(a => a.PatientID)
                .OnDelete(DeleteBehavior.Restrict);

            e.HasOne(a => a.Doctor)
                .WithMany(d => d.AppointmentsAsDoctor)
                .HasForeignKey(a => a.MedicId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<Doctor>(e =>
            {
                e.HasKey(u => u.Id);
            }

        );
        builder.Entity<Patient>(e =>
            {
                e.HasKey(u => u.Id);
            }
        );
        builder.Entity<Nurse>(e =>
            {
                e.HasKey(u => u.Id);
            }
        );
    }
    
    

}