using Microsoft.Extensions.DependencyInjection;
using PackIT.Shared.Services;

namespace PackIT.Shared;

 public static class Extensions
{
    public static IServiceCollection AddShared(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddHostedService<AppInitializer>();

        return serviceCollection; 
    }
}