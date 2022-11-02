using CryptoWatcherLib.Models;

namespace CryptoWatcherLib.DataManagers.User
{
    /// <summary>
    /// This interface contains all the functionalities of a data accessable class
    /// Because using interfaces we are not dependant of specific implementations
    /// </summary>
    public interface IUsersDbDataManager
    {
        /// <summary>
        /// Selects and returns the user from the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        IUser GetUser(IUser user);
        IUser GetUser(int id);
        void RegisterUser(IUser user);
        void ModifyUser(IUser user);
    }
}
