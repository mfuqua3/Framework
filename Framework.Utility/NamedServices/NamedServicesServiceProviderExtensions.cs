using Microsoft.Extensions.DependencyInjection;

namespace Framework.Utility.NamedServices;

public static class NamedServicesServiceProviderExtensions
{
    public static T GetRequiredService<T>(this IServiceProvider provider, string name)
    {
        var namedServices = provider.GetService<INamedServiceCollection<T>>() ??
                            NamedServiceCollection<T>.Empty;
        return namedServices.GetValueOrDefault(name) ?? 
               throw new InvalidOperationException("No Service has been registered with that name");
    }
    
    public static T GetService<T>(this IServiceProvider provider, string name)
    {
        var namedServices = provider.GetService<INamedServiceCollection<T>>() ??
                            NamedServiceCollection<T>.Empty;
        return namedServices.GetValueOrDefault(name); 
    }
}