namespace CryptoWatcherLib.Models;

public interface ICrypto
{
    void add();
    CryptoModel Update(CryptoModel cryptoModel);
    void Remove();
}