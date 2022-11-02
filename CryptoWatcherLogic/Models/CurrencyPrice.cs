using CryptoWatcherLib.DataAccess.Api;

namespace CryptoWatcherLib.Models;
/// <summary>
/// TODO Doku schreiben
/// </summary>
public class CurrencyPrice : ICurrencyPriceSpecificTime
{
    private int _id;
    private string _currencyName;
    private decimal _price;
    private DateTime _date;

    /// <summary>
    /// TODO Doku schreiben
    /// </summary>
    /// <param currencyName="currencyName"></param>
    /// <param currencyName="price"></param>
    /// <param currencyName="date"></param>
    public CurrencyPrice(string currencyName, DateTime date)
    {
        _currencyName = currencyName;
        _date = date;

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

    public DateTime GetDate()
    {
        return _date;
    }

    public decimal RefreshPrice()
    {
        _price = ServiceFactory.Instance.Resolve<IApiDataAccess>().GetCurrentCurrencyPrice(_currencyName);
        return _price;
    }
}