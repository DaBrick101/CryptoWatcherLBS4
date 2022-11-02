using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWatcherLib.DataAccess.Graph
{
    public interface IGraphData
    {        
        List<string> Currencies { get; }
        string[] Dates { get; }
        List<double> BtcValues { get; }
        List<double> EthValues { get; }
        List<double> DogeValues { get; }
    }
}
