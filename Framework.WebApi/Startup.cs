using Serilog;

namespace Framework;

public class Startup : IStartup
{
    public IServiceProvider ConfigureServices(IServiceCollection services)
    {
        throw new NotImplementedException();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseExceptionHandler();

        app.UseSerilogRequestLogging();
    }
}