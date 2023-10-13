using System.Diagnostics.CodeAnalysis;
using Framework.ExceptionHandling;
using JetBrains.Annotations;

namespace Framework.Extensions;

public static class EndpointRouteBuilderExtensions
{
    /// <summary>
    /// Maps a route that allows a client to request that the server attempt to brew coffee.
    /// </summary>
    /// <param name="endpoints"></param>
    /// <param name="pattern">The route pattern.</param>
    /// <remarks>https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/418</remarks>
    public static void MapBrewCoffee(this IEndpointRouteBuilder endpoints,
        [StringSyntax("Route"), RouteTemplate] string pattern)
        => endpoints.MapGet(pattern, ServerIsTeapotException.Throw);
}