using CryptoWatcherLib.Models;
using System.Net;
using System.Windows;
using System.Windows.Input;
using CryptoWatcherLib;

namespace CryptoWatcherWPF.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void lblRegister_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var registerWindow = new RegisterWindow();
            registerWindow.Show();
            this.Close();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            var credential = new NetworkCredential
            {
                UserName = txtUsername.Text,
                Password = tbPassword.Password
            };

            var user = new User(credential);
            user.Login();

            if (user.GetIsLoggedIn())
            {
                ServiceFactory.Instance.UserInstance = user;
                var dw = new DashboardWindow();
                this.Close();
                dw.Show();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
}
