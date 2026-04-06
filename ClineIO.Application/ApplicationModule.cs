using ClineIO.Application.Commands.Patient.AddPatient;
using Microsoft.Extensions.DependencyInjection;

namespace ClineIO.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplicationModule(this IServiceCollection services)
    {
        return services.AddMediatorModule();
    }
    
    public static IServiceCollection AddMediatorModule(this IServiceCollection services)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<AddPatientCommand>());
        return services;
    }
}