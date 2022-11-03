namespace CryptoWatcherLib.DataAccess.Api
{
    public interface IApiDataAccess
    {
        decimal GetCurrentCurrencyPrice(string currencyName);
        decimal GetConvertPrice(string currencyFrom, string currencyTo);
    }
}
