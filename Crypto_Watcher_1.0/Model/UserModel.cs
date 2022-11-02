using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWatcherLib.Models
{
    /// <summary>
    /// Model des Users beinhaltet die Propertys des Users
    /// </summary>
    public class UserModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }//Verschlüssen Becrypt UPDATE: Fetty Freddy
        public string Email { get; set; }

    }
}
