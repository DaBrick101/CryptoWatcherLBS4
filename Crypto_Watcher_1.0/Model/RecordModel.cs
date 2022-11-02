using System.Runtime.InteropServices;

namespace CryptoWatcherLib.Models;

public class RecordModel
{
    public string Date { get; set; }
    public float EUR { get; set; }
    public int UserID { get; set; }
    public int CryptoID { get; set; }
}