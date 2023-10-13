namespace Framework.Configuration;

public static class HostBuilderExtensions
{
    public static IHostBuilder BindApplicationConfigurations(this IHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureServices(services =>
        {
            //services.BindOptions<SomeOptions>();
        });
    }
}
