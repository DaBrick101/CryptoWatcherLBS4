using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWatcherLib.DataAccess.Graph
{
    public class GraphData : IGraphData
    {
        public List<string> Currencies => new List<string>()
        {
            "BTC",
            "ETH",
            "DOGE"
        };

        public List<double> BtcValues => new List<double>()
        {
            20594.40,
            20809.80,
            20626.30,
            20496.30,
            20483.50,
            20394.90,
            20522.70
        };

        public List<double> EthValues => new List<double>()
        {
            1554.47,
            1619.69,
            1590.47,
            1572.89,
            1579.64,
            1553.02,
            1542.04
        };

        public List<double> DogeValues => new List<double>()
        {
            0.083754,
            0.121873,
            0.117611,
            0.126858,
            0.142243,
            0.142243,
            0.145532
        };

        string[] IGraphData.Dates => new string[]
        {
            "28.10.2022",
            "29.10.2022",
            "30.10.2022",
            "31.10.2022",
            "01.11.2022",
            "02.11.2022",
            "03.11.2022",
        };
    }
}
