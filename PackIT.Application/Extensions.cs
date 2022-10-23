using System.ComponentModel.Design;
using Microsoft.Extensions.DependencyInjection;
using PackIT.;

namespace PackIT.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddCommands();
        return services;
    }
}