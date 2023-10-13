using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Testing.HttpProxy;

public interface IHostedTestServerBuilder
{
    public IHostedTestServerBuilder ListenAtPort(int port);
    public IHostedTestServerBuilder ConfigureServices(Action<IServiceCollection> configureServices);
    public IHostedTestServerBuilder Configure(Action<IApplicationBuilder> configureApp);
}