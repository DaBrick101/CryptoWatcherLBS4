using CryptoWatcherLib.DataAccess.Api;

namespace CryptoWatcherLib.Models;
/// <summary>
/// TODO Doku schreiben
/// </summary>
public class CurrencyPrice : ICurrencyPrice
{
    private int _id;
    private string _currencyName;
    private decimal _price;

    /// <summary>
    /// TODO Doku schreiben
    /// </summary>
    /// <param currencyName="currencyName"></param>
    /// <param currencyName="price"></param>
    public CurrencyPrice(string currencyName)
    {
        _currencyName = currencyName;

        _price = RefreshPrice();
    }

    public int GetID()
    {
        return _id;
    }

    public string GetName()
    {
        return _currencyName;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public decimal RefreshPrice()
    {
        _price = ServiceFactory.Instance.Resolve<IApiDataAccess>().GetCurrentCurrencyPrice(_currencyName);
        return _price;
    }
}