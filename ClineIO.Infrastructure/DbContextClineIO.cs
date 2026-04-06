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
    public DbSet<Professional>  Professionals { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Tenent> Tenents { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Appointment>(e =>
        {
            e.HasKey(u => u.Id);

            e.HasOne(a => a.Patient)
                .WithMany(p => p.AppointmentsAsPatient)
                .HasForeignKey(a => a.PatientID)
                .OnDelete(DeleteBehavior.Restrict);

            e.HasOne(a => a.Professional)
                .WithMany(d => d.AppointmentsAsProfessional)
                .HasForeignKey(a => a.MedicId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<Professional>(e =>
            {
                e.HasKey(u => u.Id);
            }

        );
        builder.Entity<Patient>(e =>
            {
                e.HasKey(u => u.Id);
            }
        );

        builder.Entity<Tenent>(e =>
            {
                e.HasKey(u => u.Id);

                e.HasMany(t => t.Doctors)
                    .WithMany(d => d.Tenents);
            }
        );
    }
    
    

}