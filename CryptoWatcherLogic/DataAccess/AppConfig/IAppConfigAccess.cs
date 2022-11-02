namespace CryptoWatcherLib.DataAccess.AppConfig
{
    public interface IAppConfigAccess
    {
        string GetDbConnectionString();
        string GetCryptoCurrencyApiKey();
        void UpdateAppConfigKey(string key, string value);
        
    }
}