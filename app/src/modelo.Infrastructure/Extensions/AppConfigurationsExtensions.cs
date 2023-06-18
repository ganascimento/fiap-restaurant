using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using modelo.Infrastructure.Configurations;

namespace modelo.Infrastructure.Extensions
{
    public static class AppConfigurationsExtensions
    {
        public static AppConfigurations RegisterConfigurations(this IServiceCollection servicesCollection, IConfiguration configuration)
        {
            servicesCollection.Configure<AppConfigurations>(configuration);
            servicesCollection.AddScoped(c => c.GetService<IOptionsSnapshot<AppConfigurations>>().Value);

            servicesCollection.Configure<DatabaseConfiguration>(configuration.GetSection(nameof(AppConfigurations.DatabBases)));
            servicesCollection.AddScoped(c => c.GetService<IOptionsSnapshot<DatabaseConfiguration>>().Value);

            return servicesCollection.BuildServiceProvider().GetService<AppConfigurations>();
        }
    }
}
