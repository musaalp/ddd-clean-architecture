using Infrastructure.DataAccess.Configurations;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure.DataAccess
{
    public class SQLDbConnectionFactory : ISQLDbConnectionFactory
    {
        private readonly IConfiguration _configuration;
        private readonly SQLServerDbConfiguration _dbConfiguration;

        public SQLDbConnectionFactory(IConfiguration configuration, SQLServerDbConfiguration dbConfiguration)
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
