using System;
using CryptoWatcherLib.Models;
using MySqlConnector;

namespace Crypto_Watcher_1._0.Repositories
{
    //Note to myself: Brauche noch API Daten

    public class CryptoDataRepository : RepositoryBase, ICrypto
    {
        public void add()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            conn = GetDbConnectionString();
            cmd = new MySqlCommand();

            try
            {
                conn.Open();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public CryptoModel Update(CryptoModel cryptoModel)
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            conn = GetDbConnectionString();
            cmd = new MySqlCommand();

            try
            {
                conn.Open();
                return cryptoModel;

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Remove()
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            conn = GetDbConnectionString();
            cmd = new MySqlCommand();

            try
            {
                conn.Open();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}