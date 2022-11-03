using CryptoWatcherLib;
using CryptoWatcherLib.DataAccess.Api;
using CryptoWatcherLib.DataManagers.Purchases;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CryptoWatcherWPF.View
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void btnCreateRecord_Click(object sender, RoutedEventArgs e)
        {
            PurchaseEntryWindow eh = new PurchaseEntryWindow();
            eh.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void InitializeDataGrid()
        {
            var dt = ServiceFactory.Instance.Resolve<IPurchasesDbDataManager>().GetPurchases(ServiceFactory.Instance.UserInstance);
            dt.Columns.Remove("idUser");
            dt.Columns.Remove("idPurchaseEntry");
            dgvPurchaseEntries.ItemsSource = dt.DefaultView;
        }

        private void btnGraphWindow_Click(object sender, RoutedEventArgs e)
        {
            GraphWindow gw = new GraphWindow();
            gw.Show();
            this.Close();
        }
    }
}
