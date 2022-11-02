using System.Data;
using System.Data.SqlClient;
using MySqlConnector;

namespace CryptoWatcherLib.DataAccess.Db
{
    public interface IDbDataAccess
    {
        int ExecuteSqlCmd(MySqlCommand cmd);
        DataTable GetTable(MySqlCommand cmd);
    }
}