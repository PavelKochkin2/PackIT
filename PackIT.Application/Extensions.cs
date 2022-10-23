using System.ComponentModel.Design;
using Microsoft.Extensions.DependencyInjection;
using PackIT.Domain.Factories;
using PackIT.Shared;

namespace PackIT.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddCommands();
        services.AddSingleton<IPackingListFactory, PackingListFactory>();
        return services;
    }
}