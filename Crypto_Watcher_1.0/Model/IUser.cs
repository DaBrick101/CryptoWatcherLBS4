using System.Collections.Generic;
using System.Net;

namespace CryptoWatcherLib.Models;
/// <summary>
/// Interface für die Prepared Statements 
/// </summary>
public interface IUser
{
    bool AuthenticateUser(NetworkCredential credential);
    void Add(UserModel userModel);
    void Edit(UserModel userModel);
    void Remove(UserModel userModel);
    UserModel GetById(int id);
    UserModel GetByUsername(string username);
    IEnumerable<UserModel> GetByAll();
}