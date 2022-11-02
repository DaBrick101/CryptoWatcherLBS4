using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Crypto_Watcher_1._0.Viewmodel
{
    /// <summary>
    /// 
    /// </summary>
    public class Dashboard_MainViewModel : ViewModelBase
    {
        private bool _isViewVisible = true;
        private int _usd;
        private int _eur;


        public int USD
        {
            get => _usd;
            set
            {
                _usd = value;
                OnPropertyChanged(nameof(USD));
            }
        }
        public int EUR
        {
            get => _eur;
            set
            {
                _usd = value;
                OnPropertyChanged(nameof(EUR));
            }
        }

        public ICommand CallAPI;
        public ICommand SaveReqToDb;
        public ICommand GetDataFromDB;
        public ICommand CreateRecord;
        public ICommand Calc;

        public Dashboard_MainViewModel()
        {

        }

    }
}
