
using Interfaces.RepositoryInterFace;

using Repository;
using Interfaces;

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
}
