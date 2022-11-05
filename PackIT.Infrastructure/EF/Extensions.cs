using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PackIT.Infrastructure.EF.Contexts;
using PackIT.Infrastructure.EF.Options;
using PackIT.Shared.Options;

namespace PackIT.Infrastructure.EF;

internal static class Extensions
{
    public static IServiceCollection AddPostgres(this IServiceCollection services, IConfiguration configuration)
    {
        var options = configuration.GetOptions<PostgresOptions>("Postgres");

        AddDbContexts(services, options.ConnectionString);

        return services;
    }

    private static void AddDbContexts(IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ReadDbContext>(ctx =>
            ctx.UseNpgsql(connectionString));

        services.AddDbContext<WriteDbContext>(ctx =>
            ctx.UseNpgsql(connectionString));
    }
}