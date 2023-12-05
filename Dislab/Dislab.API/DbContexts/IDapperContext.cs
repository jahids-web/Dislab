using System.Data;

namespace Dislab.API.DbContexts
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
}
