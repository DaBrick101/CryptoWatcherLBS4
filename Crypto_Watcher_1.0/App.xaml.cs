using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Crypto_Watcher_1._0.View;

namespace Crypto_Watcher_1._0
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var loginView = new LogInView();
            loginView.Show();
            loginView.IsVisibleChanged += (s,ev) =>
            {
                if (loginView.IsVisible == false && loginView.IsLoaded)
                {
                    var mainWindow = new Dashboard_new();
                    mainWindow.Show();
                    loginView.Close();
                }
            };
        }
    }
}
