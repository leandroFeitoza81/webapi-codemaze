using AccountOwnerApi.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

namespace AccountOwnerApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

        // Add services to the container.
        builder.Services.AddCors();
        builder.Services.ConfigureLoggerService();
        
        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
            app.UseDeveloperExceptionPage();
        else
            app.UseHsts();

        app.UseHttpsRedirection();
        
        app.UseStaticFiles();

        app.UseForwardedHeaders(new ForwardedHeadersOptions()
        {
            ForwardedHeaders = ForwardedHeaders.All
        });

        app.UseAuthorization();
        
        app.MapControllers();

        app.Run();
    }
}
