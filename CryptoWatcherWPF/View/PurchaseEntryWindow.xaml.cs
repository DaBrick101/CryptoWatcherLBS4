using CryptoWatcherLib;
using CryptoWatcherLib.Models;
using System.Windows;
using System.Windows.Controls;
using CryptoWatcherLib.DataManagers.Purchases;
using System.Windows.Input;
using System;

namespace CryptoWatcherWPF.View
{
    /// <summary>
    /// Interaktionslogik für PurchaseEntryWindow.xaml
    /// </summary>
    public partial class PurchaseEntryWindow : Window
    {
        public PurchaseEntryWindow()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindow dw = new DashboardWindow();
            dw.Show();
            this.Close();
        }

        private void WindowMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnCreateEntry_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    var payedEURAmount = decimal.Parse(txtPayedEURAmount.Text);
                    var date = DateTime.Now;
                    var currencyPrice = new CurrencyPrice(cbCurrency.Text);
                    var purchase = new PurchaseEntry(ServiceFactory.Instance.UserInstance, payedEURAmount, currencyPrice, date);
                    ServiceFactory.Instance.Resolve<IPurchasesDbDataManager>().InsertPurchase(purchase);
                    MessageBox.Show("Eintrag wurde Erfolgreich erstellt!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    DashboardWindow dbw = new DashboardWindow();
                    dbw.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Empty Fields!!!\n\n{ex.Message}", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    DashboardWindow dbw = new DashboardWindow();
                    dbw.Show();
                    this.Close();
                }
            
            
           
        }
    }
}
