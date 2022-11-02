namespace CryptoWatcherLib.Models
{
    public interface IPurchaseEntry
    {
        public int GetId();
        IUser GetUser();
        decimal GetPayedAmount();
        string GetCurrencyName();
        decimal GetCurrencyPrice();
        DateTime GetDate();
        decimal GetPayedAmountInCurrency();

    }
}
