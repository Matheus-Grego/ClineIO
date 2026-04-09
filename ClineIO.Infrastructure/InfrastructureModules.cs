using ClineIO.Core.Entities;
using ClineIO.Core.Repositories;
using ClineIO.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClineIO.Infrastructure;

public static class InfrastructureModules
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRepositories();
        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPatientRepository, PatientRepository>();
        services.AddScoped<IProfessionalRepository, ProfessionalRepository>();
        services.AddScoped<ITenentRepository, TenentRepository>();
        services.AddScoped<IMedicalServiceRepository, MedicalServiceRepository>();
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        return services;
    }
    
}