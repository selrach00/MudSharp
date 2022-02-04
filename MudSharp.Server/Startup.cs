using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudSharp.Data;
using System;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        ConfigureDatabaseService(services);
    }

    public virtual void ConfigureDatabaseService(IServiceCollection services)
    {
        try
        {
            var connectionString = Configuration.GetSection("DbConnectionString").Value;
            services.AddDbContext<MudDbContext>(
                o => o.UseSqlServer(connectionString),
                ServiceLifetime.Transient);
        }
        catch (Exception ex)
        {
            throw new Exception($"{ex}");
        }
    }
}