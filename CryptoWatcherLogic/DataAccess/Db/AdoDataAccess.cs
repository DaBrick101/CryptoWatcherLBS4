using CryptoWatcherLib.DataAccess.AppConfig;
using MySqlConnector;
using System.Data;

namespace CryptoWatcherLib.DataAccess.Db
{
    public class AdoDataAccess : IDbDataAccess
    {
        private readonly string _conString;

        public AdoDataAccess()
        {
            _conString = ServiceFactory.Instance.Resolve<IAppConfigAccess>().GetDbConnectionString();
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(_conString);
        }

        public DataTable GetTable(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                using (cmd.Connection = GetConnection())
                {
                    cmd.Connection.Open();
                    cmd.Prepare();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error while executing following sql command: {cmd.CommandText} | Errormessage: {e.Message} | InnerException: {e.InnerException} | Stacktrace: {e.StackTrace}");
            }
            finally
            {
                cmd.Connection.Close();
            }

            return dt;
        }

        public int ExecuteSqlCmd(MySqlCommand cmd)
        {
            int affectedRows = 0;
            try
            {
                using (cmd.Connection = GetConnection())
                {
                    cmd.Connection.Open();
                    cmd.Prepare();
                    affectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error while executing following sql command: {cmd.CommandText} | Errormessage: {e.Message} | InnerException: {e.InnerException} | Stacktrace: {e.StackTrace}");
            }
            finally
            {
                cmd.Connection.Close();
            }
            return affectedRows;
        }
    }
}
