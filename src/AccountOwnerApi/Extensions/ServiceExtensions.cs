using Contracts;
using LoggerService;

namespace AccountOwnerApi.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                    //.AllowAnyMethod()
                    .WithMethods("GET", "POST")
                    //.AllowAnyHeader());
                    .WithHeaders("accept", "content-type"));
        });
    }

    public static void ConfigureLoggerService(this IServiceCollection services)
    {
        services.AddSingleton<ILoggerManager, LoggerManager>();
    }
}