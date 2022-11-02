using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySqlConnector;


namespace Crypto_Watcher_1._0.Repositories
{
    /// <summary>
    /// Baut den Connection string auf und gibt ihn zurück
    /// </summary>
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        private readonly MySqlConnection _connection;

        /// <summary>
        /// Baut aus den gegebenen Parametern einen Connection string zusammen
        /// </summary>
        public RepositoryBase()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "crypto-watcher-db.mysql.database.azure.com",
                Database = "crypto_watcher_db",
                UserID = "cryBur0_a@crypto-watcher-db",
                Password = "Gschacht#!"
            };

            _connection = new MySqlConnection(builder.ConnectionString);
        }
        /// <summary>
        /// Gibt den Connectons String zurück
        /// </summary>
        /// <returns>_connection</returns>
        public MySqlConnection GetDbConnectionString()
        {
            return _connection;
        }

    }
}
