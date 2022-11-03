using CryptoWatcherLib.DataAccess.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWatcherLib.Models
{
    public class CurrencyConvertPrice : ICurrencyConvertPrice
    {
        private int _id;
        private string _currencyNameFrom;
        private string _currencyNameTo;
        private decimal _price;

        public CurrencyConvertPrice(string currencyNameFrom, string currencyTo)
        {
            _currencyNameFrom = currencyNameFrom;
            _currencyNameTo = currencyTo;

            _price = RefreshPrice();
        }

        private decimal RefreshPrice()
        {
            _price = ServiceFactory.Instance.Resolve<IApiDataAccess>().GetConvertPrice(_currencyNameFrom, _currencyNameTo);
            return _price;
        }

        public decimal GetConvertPrice()
        {
            return _price;
        }

        public int GetID()
        {
            return _id;
        }

        public string GetNameFrom()
        {
            return _currencyNameFrom;
        }

        public string GetNameTo()
        {
            return _currencyNameTo;
        }
    }
}
