using Interfaces;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using NLog;
using StorageManager.Extention;

var builder = WebApplication.CreateBuilder(args);
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
builder.Services.AddControllers();
builder.Services.ConfigureCors(); 
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureRepositoryMnager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureSqlContext(builder.Configuration);
var app = builder.Build();
app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
 app.UseDeveloperExceptionPage(); 
 else 
 app.UseHsts();

app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions { ForwardedHeaders = ForwardedHeaders.All }); 
app.UseCors("CorsPolicy");

app.UseAuthorization(); 
app.MapControllers(); 
app.Run();
[Route("[controller]")] 
[ApiController] 
public class WeatherForecastController : ControllerBase
 { private readonly IloggerManager _logger;
  public WeatherForecastController(IloggerManager logger)
   { _logger = logger; } [HttpGet] public IEnumerable<string> Get()
    { _logger.LogInfo("Here is info message from our values controller.");
     _logger.LogDebug("Here is debug message from our values controller.");
      _logger.LogWarn("Here is warn message from our values controller.");
       _logger.LogError("Here is an error message from our values controller.");
        return new string[] { "value1", "value2" };
    } 
 }