using System.Data;


namespace MMS.Infrastructure.Data
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}