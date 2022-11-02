using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CryptoWatcherLib.Models;
using Crypto_Watcher_1._0.Repositories;
using Crypto_Watcher_1._0.View;
using MySqlConnector;


namespace Crypto_Watcher_1._0.Viewmodel
{
    /// <summary>
    /// Führt Commands aus, holt und setzt die Werte der Fields:
    /// _username
    /// _password
    /// _errorMessage
    /// _isViewVisible
    /// </summary>
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        private string _password;
        private string _errorMessage;
        private bool _isViewVisible = true;
        private Visibility _loginVisibility;

        private IUser userRepository;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Get und Set Username beim Login
        /// </summary>
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        /// <summary>
        /// Get und Set Passwort beim Login
        /// </summary>
        public string Password
        {
            get => _password;
            set
            {
                //_password = BCrypt.Net.BCrypt.HashPassword(value.ToString());
                _password = value;
                OnPropertyChanged(nameof(Password));
            }

        }

        /// <summary>
        /// Get und Set ErrorMessage, falls Eingabe ungültig ist oder Falsch
        /// </summary>
        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        /// <summary>
        /// Get und Set ob die LoginView Visible ist oder nicht.
        /// </summary>
        public bool IsViewVisible
        {
            get => _isViewVisible;
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
                
            }
        }

        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }
        

        /// <summary>
        /// Konstruktor des LogInViewModel
        /// </summary>
        public LoginViewModel()
        {
            userRepository = new UserRepository();
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new ViewModelCommand(p => ExecuteRecoverPasswordCommand("", ""));
        }

        /// <summary>
        /// Überprüft ob die Eingabe von Username und Passwort erlaubt sind.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Ein Bool mit Information ob die Daten zugelassen werden oder nicht</returns>
        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 ||
                Password == null || Password.Length < 3)
            {

                validData = false;
            }
            else
            {
                validData = true;
            }
            return validData;
        }
        /// <summary>
        /// Führt den Login aus wenn, der User durch die Methode "AuthenticateUser" als Valid bestätigt wird.
        /// Sollte der User nicht Valid sein wird die ErrorMessag auf "Invalid username or password" gesetzt.
        /// Sollte der User Valid sein wird er Angemeldet und die LoginView ist nicht mehr Visible.
        /// </summary>
        /// <param name="obj"></param>
        private void ExecuteLoginCommand(object obj)
        {
            var isValidUser = userRepository.AuthenticateUser(new NetworkCredential(Username, Password));
            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(Username), null);
                    IsViewVisible = false;
                    ErrorMessage = "";
                    


            }
            else
            {
                ErrorMessage = "* Invalid username or password";
            }
        }
        private void ExecuteRecoverPasswordCommand(string username, string email)
        {
            throw new NotImplementedException();
        }
        private void ExecuteShowPasswordCommand(object obj)
        {
            throw new NotImplementedException();
        }
        private void ExecuteRememberPasswordCommand(object obj)
        {
            throw new NotImplementedException();
        }


    }
}
