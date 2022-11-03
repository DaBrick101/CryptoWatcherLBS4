using CryptoWatcherLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CryptoWatcherWPF.View
{
    /// <summary>
    /// Interaktionslogik für CurrencyConverterWindow.xaml
    /// </summary>
    public partial class CurrencyConverterWindow : Window
    {
        public CurrencyConverterWindow()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
        private void btnDashboardWindow_Click(object sender, RoutedEventArgs e)
        {
            DashboardWindow dbw = new DashboardWindow();
            dbw.Show();
            this.Close();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            var amountFrom = cbCurrencyFrom.Text;
            var amountTo = cbCurrencyTo.Text;
            var currencyConvertPrice = new CurrencyConvertPrice(amountFrom, amountTo);
            var convertedPrice = currencyConvertPrice.GetConvertPrice() * decimal.Parse(txtAmountFrom.Text);
            txtConvertedPrice.Text = Math.Round(convertedPrice, 2).ToString();
        }

    }
}
