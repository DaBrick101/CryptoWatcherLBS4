using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace Crypto_Watcher_1._0.CustomControls
{
    /// <summary>
    /// Interaktionslogik für BindablePasswordBox.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(BindablePasswordBox));

        /// <summary>
        /// Setzt das Passwort fest und gibt den Wert des Passworts zurück
        /// </summary>
        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }
        /// <summary>
        /// Initzaliesiert die Passwortbox Komponente
        /// </summary>
        public BindablePasswordBox()
        {
            InitializeComponent();
            txtPassword_Ctrl.PasswordChanged += OnPasswordChanged;
        }
        
        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = txtPassword_Ctrl.Password;
        }
    }
}

