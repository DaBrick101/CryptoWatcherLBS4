using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoWatcherLib;
using CryptoWatcherLib.DataAccess.AppConfig;

namespace CryptoWatcherConsole
{
    /// <summary>
    /// Here you can Add Diffrent TestCases
    /// </summary>
    public class ConsoleTest
    {
        public void ExecuteTestMethod()
        {
            /* CALL TEST METHOD HERE
            
            */
            GetAppConfigKeys();
            

        }

        public void GetAppConfigKeys()
        {
            var apiAccess = ServiceFactory.Instance.Resolve<IAppConfigAccess>();

            var apiKey = apiAccess.GetCryptoCurrencyApiKey();
            var connectionString = ServiceFactory.Instance.Resolve<IAppConfigAccess>().GetDbConnectionString();
        }
    }
}
