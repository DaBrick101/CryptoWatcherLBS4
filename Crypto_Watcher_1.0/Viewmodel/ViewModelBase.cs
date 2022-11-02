using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Watcher_1._0.Viewmodel
{
    /// <summary>
    /// Im ViewModelBase wird überprüft ob sich etwas auf der View geändert hat.
    /// Wird etwas geändert, wird die Property Invoked 
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
