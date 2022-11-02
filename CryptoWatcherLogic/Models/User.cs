using CryptoWatcherLib.DataManagers.User;
using System.Data;
using System.Net;

namespace CryptoWatcherLib.Models
{
    /// <summary>
    /// Model des Users beinhaltet die Properties des Users
    /// </summary>
    public class User : IUser
    {
        private int _id;
        private string _username;
        private string _password;
        private bool _isLoggedIn;

        public User(NetworkCredential credential)
        {
            _username = credential.UserName;
            _password = credential.Password;

            _isLoggedIn = false;
        }

        public User(DataRow data)
        {
            _id = Convert.ToInt32(data["idUser"]);
            _username = data["Username"].ToString();
            _password = data["Password"].ToString();
        }

        public int GetId()
        {
            return _id;
        }

        public string GetUsername()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }

        public bool GetIsLoggedIn()
        {
            return _isLoggedIn;
        }

        /// <summary>
        /// Sets the login state on true
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void Login()
        {
            var userFromDb = ServiceFactory.Instance.Resolve<IUsersDbDataManager>().GetUser(this);
            if (userFromDb is null)
            {
                throw new Exception("Error while user login | user could not found");
            }
            
            var isPwMatching = BCrypt.Net.BCrypt.Verify(_password, userFromDb.GetPassword());
            

            if (isPwMatching)
            {
                _id = userFromDb.GetId();
                _isLoggedIn = true;
            }
        }

        /// <summary>
        /// inserts a new user in database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Register()
        {
            if (_isLoggedIn)
            {
                throw new Exception("User is already logged in");
            }
            ServiceFactory.Instance.Resolve<IUsersDbDataManager>().RegisterUser(this);
            return true;
        }

    }
}
