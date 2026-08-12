
using Interfaces.RepositoryInterFace;
using Repository;
using Service;
using Interfaces;
using Interfaces.ServiceManager;
using Microsoft.EntityFrameworkCore;

namespace StorageManager.Extention;

public static class ServiceExtention
{
    public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
    {
       options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
        .AllowAnyMethod() 
        .AllowAnyHeader()); 
    });
    public static void ConfigureLoggerService(this IServiceCollection services) => 
     services.AddSingleton<IloggerManager, loggerManager>();

    public static void ConfigureRepositoryMnager(this IServiceCollection services)=>
    services.AddScoped<IRepositoryManager,RepositoryManager>();
    public static void ConfigureServiceManager(this IServiceCollection services)=>
    services.AddScoped<ISeviceManager,ServiceManager>();
    public static void ConfigureSqlContext(this IServiceCollection services, 
    IConfiguration configuration) => 
    services.AddDbContext<RepositoryContex>(opts => 
    opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"))); 
}
