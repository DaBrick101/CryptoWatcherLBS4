namespace CryptoWatcherLib.Models
{
    public interface ICurrencyPriceSpecificTime
    {
        int GetID();
        string GetName();
        decimal GetPrice();
        DateTime GetDate();
    }
}
