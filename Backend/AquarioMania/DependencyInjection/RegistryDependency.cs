using AquarioMania.Repository;
using AquarioMania.Service;
using AquarioMania.Utils;
using Microsoft.Extensions.Options;

namespace AquarioMania.DependencyInjection;

public class RegistryDependency
{
    public static void RegisterServices(IServiceCollection services)
    {

        services.AddScoped<ILivingBeingInterface, LivingBeingService>(
            provider => new LivingBeingService(provider.GetService<ILivingBeingRepository>(), provider.GetRequiredService<IOptions<AquarioManiaSettings>>().Value));

        services.AddScoped<IUserInterface, UserService>(
            provider => new UserService(provider.GetService<IUserRepository>(), provider.GetRequiredService<IOptions<AquarioManiaSettings>>().Value));

        services.AddScoped<ISessionInterface, SessionService>(provider =>
                new SessionService(provider.GetService<IUserInterface>(),
                    provider.GetRequiredService<IOptions<AquarioManiaSettings>>().Value));
    }

    public static void RegisterRepository(IServiceCollection services)
    {
        services.AddScoped<ILivingBeingRepository, LivingBeingRepository>();

        services.AddScoped<IUserRepository, UserRepository>();
    }
}
