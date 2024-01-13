using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Dislab.Base.DbContexts
{
    public class DapperContext : IDapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string? _configurationString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _configurationString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_configurationString);
        }
    }
}
