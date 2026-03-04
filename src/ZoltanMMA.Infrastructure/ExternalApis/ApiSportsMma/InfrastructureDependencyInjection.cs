using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ZoltanMMA.Infrastructure.ExternalApis.ApiSportsMma
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddHttpClient<IApiSportsClient, ApiSportsClient>(client =>
            {
                client.BaseAddress = new Uri("https://v1.mma.api-sports.io/");
                client.DefaultRequestHeaders.Add(
                    "x-apisports-key",
                    configuration["ApiSports:Key"]);
            });

            return services;
        }
    }
}
