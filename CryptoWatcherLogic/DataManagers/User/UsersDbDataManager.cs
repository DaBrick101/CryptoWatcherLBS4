using System.Data.SqlClient;
using CryptoWatcherLib.DataAccess.Db;
using CryptoWatcherLib.Models;
using MySqlConnector;

namespace CryptoWatcherLib.DataManagers.User
{
    /// <summary>
    /// This class is implementing the IUsersDataManager interface. 
    /// It contains all functionalities that are needed when accessing data in the database.
    /// </summary>
    public class UsersDbDataManager : IUsersDbDataManager
    {
        IDbDataAccess _dbAccessManager;

        /// <summary>
        /// This constructor will only be called when resolving the class in ServiceFactory
        /// </summary>
        /// <param name="dbAccessManager"></param>

        //TODO: Modify sql strings and don't forget to test it
        public UsersDbDataManager(IDbDataAccess dbAccessManager)
        {
            _dbAccessManager = dbAccessManager;
        }

        public IUser GetUser(IUser user)
        {
            var cmdText = "SELECT * FROM crypto_watcher_db.user WHERE Username = @username";
            var cmd = new MySqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@username", user.GetUsername());

            var dt = _dbAccessManager.GetTable(cmd);

            if (dt.Rows.Count != 1)
            {
                throw new Exception("Error accessing db | database did send back more than 1 user");
            }

            return new Models.User(dt.Rows[0]);
        }

        public IUser GetUser(int id)
        {
            var cmdText = "SELECT * FROM crypto_watcher_db.user WHERE idUser = @userId";
            var cmd = new MySqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@userId", id);

            var dt = _dbAccessManager.GetTable(cmd);

            if (dt.Rows.Count != 1)
            {
                throw new Exception("Error accessing db | database did send back more than 1 user");
            }

            return new Models.User(dt.Rows[0]);
        }

        /// <summary>
        /// inserts a new user in the database table users
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="Exception"></exception>
        public void RegisterUser(IUser user)
        {
            string cmdText = "INSERT INTO crypto_watcher_db.user(Username, Password)" +
                             "Value (@userName, @pw)";

            MySqlCommand cmd = new MySqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@userName", user.GetUsername());
            var password = user.GetPassword();
            password = BCrypt.Net.BCrypt.HashPassword(password);
            cmd.Parameters.AddWithValue("@pw", password);

            if (_dbAccessManager.ExecuteSqlCmd(cmd) != 1)
            {
                throw new Exception("Error while registration | more than 1 affected row");
            }
        }

        /// <summary>
        /// updates an existing user in the database
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="Exception"></exception>
        public void ModifyUser(IUser user)
        {
            //table names might be incorrect
            string cmdText = "UPDATE crypto_watcher_db.user Username=@username, Password=@password" +
                             "WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@userName", user.GetUsername());
            cmd.Parameters.AddWithValue("@password", user.GetPassword());
            cmd.Parameters.AddWithValue("@id", user.GetId());

            if (_dbAccessManager.ExecuteSqlCmd(cmd) != 1)
            {
                throw new Exception("sql statement effected more than 1 row");
            }
        }
    }
}
