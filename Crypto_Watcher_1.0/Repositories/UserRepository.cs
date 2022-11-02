using CryptoWatcherLib.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;

namespace Crypto_Watcher_1._0.Repositories
{
    /// <summary>
    /// Alle funktionen die den User betreffen beim Login.
    /// </summary>
    public class UserRepository : RepositoryBase, IUser
    {
        /// <summary>
        /// Der User wird beim Login überprüft, ob die angegebenen Daten in der Datenbank vorhanden sind
        /// Ist der User vorhanden wird der Wert von validUser auf True gesetzt.
        /// Ansonsten wird validUser auf false gesetzt und eine Error Message(invalid Userame or Password) ausgegeben.
        /// </summary>
        /// <param name="credential"></param>
        /// <returns></returns>
        public bool AuthenticateUser(NetworkCredential credential)
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            conn = GetDbConnectionString();
            cmd = new MySqlCommand();

            object passwordHash = null;
            try
            {


                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "Select Passwort from User where Username=@username";
                cmd.Prepare();
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = credential.UserName;
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        passwordHash = rdr.GetValue("Passwort");
                    }
                }

                if (passwordHash != null)
                {
                    bool validUser = BCrypt.Net.BCrypt.Verify(credential.Password, (string)passwordHash);
                    conn.Close();
                    return validUser;
                }
                else
                {
                    conn.Close();
                    return false;
                }

            }
            catch (MySqlException ex)
            {
                var exception = ex as MySqlException;
                return false;
            }


        }
        /// <summary>
        /// Registrations Methode
        /// </summary>
        /// <param name="userModel"></param>
        public void Add(UserModel userModel)
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            conn = GetDbConnectionString();
            cmd = new MySqlCommand();

            try
            {

            }
            catch
            {

            }
        }
        /// <summary>
        /// Edit Username oder Password Methode
        /// </summary>
        /// <param name="userModel"></param>
        public void Edit(UserModel userModel)
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            conn = GetDbConnectionString();
            cmd = new MySqlCommand();

            try
            {

            }
            catch
            {

            }
        }
        /// <summary>
        /// User löschen
        /// </summary>
        /// <param name="userModel"></param>
        public void Remove(UserModel userModel)
        {
            MySqlConnection conn;
            MySqlCommand cmd;

            conn = GetDbConnectionString();
            cmd = new MySqlCommand();

            try
            {

            }
            catch
            {

            }
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetByAll()
        {
            throw new NotImplementedException();
        }
    }
}
