using Microsoft.Extensions.Options;
using OpenTelemetry;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace Framework.OpenTelemetry;

public static class OpenTelemetryServiceCollectionExtensions
{

    public static IServiceCollection AddApplicationOpenTelemetry(this IServiceCollection services,
        string serviceName,
        Action<TracerProviderBuilder> configureTracing)
    {
        services.AddOpenTelemetry()
            .WithTracing(tracerProviderBuilder =>
            {
                tracerProviderBuilder
                    .SetResourceBuilder(
                        ResourceBuilder.CreateDefault().AddService(serviceName));
                configureTracing.Invoke(tracerProviderBuilder);
            });
        return services;
    }
}