using Infrastructure.DataAccess.Configurations;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure.DataAccess
{
    public class MSSqlConnectionFactory : IMSSqlConnectionFactory
    {
        private readonly IConfiguration _configuration;
        private readonly MSSqlDbConfiguration _dbConfiguration;

        public MSSqlConnectionFactory(IConfiguration configuration, MSSqlDbConfiguration dbConfiguration)
        {
            _configuration = configuration;
            _dbConfiguration = dbConfiguration;
        }

        public IDbConnection Create()
        {
            string connectionString = _dbConfiguration.ToConnectionString(_configuration.GetConnectionString("App"));

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            return new SqlConnection(connectionString);
        }
    }
}
