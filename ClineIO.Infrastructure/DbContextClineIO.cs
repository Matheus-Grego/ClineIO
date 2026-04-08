using System.Text.Json.Nodes;
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
    public DbSet<MedicalService> MedicalServices { get; set; }
    public DbSet<TenentProfessional> TenentProfessionals { get; set; }


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
                .HasForeignKey(a => a.ProfessionalId)
                .OnDelete(DeleteBehavior.Restrict);
            
            e.HasOne(a => a.Tenent)
                .WithMany()
                .HasForeignKey(a => a.TenentId)
                .OnDelete(DeleteBehavior.Restrict);
            
            e.HasOne(a => a.MedicalServiceCategory)
                .WithMany() 
                .HasForeignKey(a => a.MedicalServiceCategoryId)
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

                e.HasMany(t => t.TenentProfessionals)
                    .WithOne(tp => tp.Tenent)
                    .HasForeignKey(tp => tp.TenentId);
            }
        );

        builder.Entity<TenentProfessional>(e =>
        {
            e.HasKey(u => u.Id);
            
            e.Property(x => x.WorkScale)
                .HasConversion(
                    v => v.ToJsonString(),
                    v => JsonNode.Parse(v).AsArray()
                );

            e.HasOne(x => x.Tenent)
                .WithMany(t => t.TenentProfessionals)
                .HasForeignKey(x => x.TenentId)
                .OnDelete(DeleteBehavior.Restrict);

            e.HasOne(x => x.Professional)
                .WithMany(p => p.Tenents)
                .HasForeignKey(x => x.ProfessionalId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
    
    

}