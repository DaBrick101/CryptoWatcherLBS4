using CryptoWatcherLib.DataAccess.AppConfig;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CryptoWatcherLib.DataAccess.Api
{
    public class ApiDataAccess : IApiDataAccess
    {
        private readonly string _key;
        
        public ApiDataAccess()
        {
            _key = ServiceFactory.Instance.Resolve<IAppConfigAccess>().GetCryptoCurrencyApiKey();
        }

        public decimal GetCurrentCurrencyPrice(string currencyName)
        {
            var url = $"https://min-api.cryptocompare.com/data/pricemulti?fsyms={currencyName}&tsyms=EUR&api_key={_key}";

            var client = new RestClient(url);
            var response = client.Execute(new RestRequest());

            var price = ParseKeyFromJson(response.Content, "EUR");
            if (price == 0)
            {
                throw new Exception("Price is 0");
            }

            return price;
        }

        private decimal ParseKeyFromJson(string json, string key)
        {
            var objects = JObject.Parse(json);
            foreach (var root in objects)
            {
                return (decimal)root.Value[key];
            }
            return 0;
        }
    }
}
