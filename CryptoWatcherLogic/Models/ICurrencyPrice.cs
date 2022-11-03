namespace CryptoWatcherLib.Models
{
    public interface ICurrencyPrice
    {
        int GetID();
        string GetName();
        decimal GetPrice();
    }
}
