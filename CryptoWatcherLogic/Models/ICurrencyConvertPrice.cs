using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWatcherLib.Models
{
    public interface ICurrencyConvertPrice
    {
        int GetID();
        string GetNameFrom();
        string GetNameTo();
        decimal GetConvertPrice();
    }
}
