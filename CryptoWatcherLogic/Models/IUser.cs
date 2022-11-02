namespace CryptoWatcherLib.Models
{
    public interface IUser
    {
        int GetId();
        string GetUsername();
        string GetPassword();
        bool GetIsLoggedIn();
        void Login();
        bool Register();
    }
}
