namespace CryptoWatcherLib.Models;

public interface IRecord
{
    void Add(RecordModel recordModel);
    void Edit(RecordModel recordModel);
    void Remove(RecordModel recordModel);
    RecordModel GetbyID();
}