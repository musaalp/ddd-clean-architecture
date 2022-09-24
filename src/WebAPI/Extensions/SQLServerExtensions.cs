using Domain.Entities;
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.Configurations;
using Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.Options;

namespace WebAPI.Extensions
{
    public static class SQLServerExtensions
    {
        public static IServiceCollection AddSQLServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ISQLDbConnectionFactory, SQLDbConnectionFactory>();

            services.Configure<SQLServerDbConfiguration>(configuration.GetSection("Database:App"));
            services.AddScoped(resolver => resolver.GetRequiredService<IOptionsSnapshot<SQLServerDbConfiguration>>().Value);

            return services;
        }
    }
}
