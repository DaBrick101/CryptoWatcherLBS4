using System.Data;
using CryptoWatcherLib.DataManagers.User;

namespace CryptoWatcherLib.Models
{
    public class PurchaseEntry : IPurchaseEntry
    {
        private int _id;
        private IUser _user;
        private decimal _payedAmount;
        private string _currency;
        private Decimal _currencyPrice;
        private DateTime _date;
        private Decimal _payedAmountInCurrency;

        public PurchaseEntry(IUser user, decimal payedAmount,ICurrencyPriceSpecificTime currency, DateTime date)
        {
            _user = user;
            _payedAmount = payedAmount;
            _currency = currency.GetName();
            _currencyPrice = currency.GetPrice();
            _date = date;
            _payedAmountInCurrency = CalcCurrency();
        }

        public int GetId()
        {
            return _id;
        }
        public IUser GetUser()
        {
            return _user;
        }

        public decimal GetPayedAmount()
        {
            return _payedAmount;
        }

        public string GetCurrencyName()
        {
            return _currency;
        }

        public decimal GetCurrencyPrice()
        {
            return _currencyPrice;
        }

        public decimal GetPayedAmountInCurrency()
        {
            return _payedAmountInCurrency;
        }
        public DateTime GetDate()
        {
            return _date;
        }
        private decimal CalcCurrency()
        {
            _payedAmountInCurrency = 1 / _currencyPrice * _payedAmount;
            return _payedAmountInCurrency;
        }
    }
}
