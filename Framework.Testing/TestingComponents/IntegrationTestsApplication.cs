using Framework.Testing.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Framework.Testing.TestingComponents;

internal class IntegrationTestsApplication : WebApplicationFactory<Program> //TODO
{
    private readonly string _databaseName;


    public IntegrationTestsApplication(string databaseName)
    {
        _databaseName = databaseName;
    }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services => { });
        base.ConfigureWebHost(builder);
        builder.ConfigureServices((ctx, services) => { });
    }

    protected override IHostBuilder CreateHostBuilder()
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? Environments.Development;

        var sink = new LogEventPublishingSink();

        return Program.CreateHostBuilder()
            .UseEnvironment(environment)
            .ConfigureServices(services => services.AddSingleton(sink))
            .UseSerilog((ctx, services, lc) =>
            {
                Program.ConfigureLogging(ctx, services, lc);
                lc.WriteTo.Sink(sink);
            });
    }
}