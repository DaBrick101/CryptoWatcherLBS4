using System.Data;
using CryptoWatcherLib.DataAccess.Db;
using CryptoWatcherLib.Models;
using MySqlConnector;

namespace CryptoWatcherLib.DataManagers.Purchases
{
    /// <summary>
    /// This class is implementing the IUsersDataManager interface. 
    /// It contains all functionalities that are needed when accessing data in the database.
    /// </summary>
    public class PurchasesDbDataManager : IPurchasesDbDataManager
    {
        IDbDataAccess _dbAccessManager;

        /// <summary>
        /// This constructor will only be called when resolving the class in ServiceFactory
        /// </summary>
        /// <param name="dbAccess"></param>

        //TODO: Modify sql strings and don't forget to test it
        public PurchasesDbDataManager(IDbDataAccess dbAccessManager)
        {
            _dbAccessManager = dbAccessManager;
        }

        /// <summary>
        /// Gets all Purchases from User with Userid
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable GetPurchases(IUser user)
        {
            var cmdText = "SELECT * FROM crypto_watcher_db.purchaseentry WHERE idUser = @idUser";
            var cmd = new MySqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@idUser", user.GetId());
            return _dbAccessManager.GetTable(cmd);
        }

        /// <summary>
        /// Insert a new entry in purchaseEntry Table
        /// </summary>
        /// <param name="purchaseEntry"></param>
        /// <exception cref="Exception"></exception>
        public void InsertPurchase(IPurchaseEntry purchaseEntry)
        {
            //idCurrency wird in einer Liste hinterlegt: BTC:1, ETH:2, DOGE:3 usw...
            //Mit der Liste wird auf der PurchaseEntry seite ein Dropdown so in der Art befüllt.
            //Wählt der User dann BTC aus zack Boom habe ich die CurrencyId sowie eine Gleichbleibende eingabe für den API Call
            //UPDATE: Hoffe ich bin nicht High und das ist kein Bullshit
            var cmdText = "INSERT INTO crypto_watcher_db.purchaseentry(idUser, PayedEURAmount, Currency, CurrencyPrice, Date, PayedAmountInCurrency)" +
                                "Values(@idUser, @payedEURAmount, @currencyName, @currencyPrice, @date, @payedAmountInCurrency)";
            var cmd = new MySqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@idUser", purchaseEntry.GetUser().GetId());
            cmd.Parameters.AddWithValue("@payedEURAmount", purchaseEntry.GetPayedAmount());
            cmd.Parameters.AddWithValue("@currencyName", purchaseEntry.GetCurrencyName());
            cmd.Parameters.AddWithValue("@currencyPrice", purchaseEntry.GetCurrencyPrice());
            cmd.Parameters.AddWithValue("@date", purchaseEntry.GetDate());
            cmd.Parameters.AddWithValue("@payedAmountInCurrency", purchaseEntry.GetPayedAmountInCurrency());


            if (_dbAccessManager.ExecuteSqlCmd(cmd) != 1)
            {
                throw new Exception("Error while registration | more than 1 affected row");
            }
        }

        public void ModifyPurchase(IPurchaseEntry purchaseEntry)
        {
            //table names might be incorrect
            var cmdText = "UPDATE crypto_watcher_db.purchaseentry SET PayedEUROAmount=@payedEURAmount, Currency=@currencyName, CurrencyPrice=@currencyPrice, idCurrency=@idCurrency, Date=@date" +
                          "WHERE idPurchaseentry=@idPurchaseentry";

            var cmd = new MySqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@idUser", purchaseEntry.GetUser().GetId());
            cmd.Parameters.AddWithValue("@payedEURAmount", purchaseEntry.GetPayedAmount());
            cmd.Parameters.AddWithValue("@currencyName", purchaseEntry.GetCurrencyName());
            cmd.Parameters.AddWithValue("@currencyPrice", purchaseEntry.GetCurrencyPrice());
            cmd.Parameters.AddWithValue("@date", purchaseEntry.GetDate());
            cmd.Parameters.AddWithValue("@@idPurchaseentry", purchaseEntry.GetId());

            if (_dbAccessManager.ExecuteSqlCmd(cmd) != 1)
            {
                throw new Exception("Error while registration | more than 1 affected row");
            }
        }
        /// <summary>
        /// Delets PurchaseEntry in purchaseEntry Table
        /// </summary>
        /// <param name="purchaseEntry"></param>
        /// <exception cref="Exception"></exception>
        public void DeletePurchase(IPurchaseEntry purchaseEntry)
        {
            var cmdText = "DELETE FROM crypto_watcher_db.purchaseentry" +
                                "WHERE idPurchaseEntry = @idPurchaseEntry";
            var cmd = new MySqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@idPurchaseEntry", purchaseEntry.GetId());


            if (_dbAccessManager.ExecuteSqlCmd(cmd) != 1)
            {
                throw new Exception("Error while registration | more than 1 affected row");
            }
        }
    }
}
