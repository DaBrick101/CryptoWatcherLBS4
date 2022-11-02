using CryptoWatcherLib.Models;
using System.Data;

namespace CryptoWatcherLib.DataManagers.Purchases
{
    public interface IPurchasesDbDataManager
    {
        DataTable GetPurchases(IUser user);
        void InsertPurchase(IPurchaseEntry purchaseEntry);
        void ModifyPurchase(IPurchaseEntry purchaseEntry);
        void DeletePurchase(IPurchaseEntry purchaseEntry);
    }
}
