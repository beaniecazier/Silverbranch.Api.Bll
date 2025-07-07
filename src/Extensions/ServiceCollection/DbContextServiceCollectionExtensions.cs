using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Gay.Silverbranch.API.BLL.Extensions.ServiceCollection;

public static class DbContextServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase<T>(
        this IServiceCollection services,
        ConfigurationManager config,
        string connStrConfigName,
        bool verbose = false)
    where T : DbContext
    {
        var connStr = config.GetValue<string>(connStrConfigName);
        if (string.IsNullOrWhiteSpace(connStr))
        {
            Log.Fatal("Connection String was null");
            return services;
        }
        if (verbose) Log.Verbose("Connection String was " + connStr);

        services.AddDbContext<T>(options =>
        {
            options.UseSqlServer(connStr);
        });
        return services;
    }
}