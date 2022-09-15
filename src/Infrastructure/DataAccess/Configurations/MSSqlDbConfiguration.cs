namespace Infrastructure.DataAccess.Configurations
{
    public class MSSqlDbConfiguration
    {
        public string Server { get; set; }
        public string Schema { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string ToConnectionString(string connectionStringTemplate)
        {
            return string.Format(connectionStringTemplate,
                Server,
                Schema,
                Username,
                Password);
        }
    }
}
