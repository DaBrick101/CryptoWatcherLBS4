namespace CryptoWatcherLib.DataAccess.Api
{
    public interface IApiDataAccess
    {
        decimal GetCurrentCurrencyPrice(string currencyName);
    }
}
