using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrasAvalonia.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {

        // Implement the PropertyChanged event required by INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        // Call this method when a property value changes to notify the UI
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Example of a property
        private string _exampleProperty;
        public string ExampleProperty
        {
            get => _exampleProperty;
            set
            {
                if (_exampleProperty != value)
                {
                    _exampleProperty = value;
                    OnPropertyChanged(nameof(ExampleProperty));
                }
            }
        }

        // Add more properties and methods that your settings require
    }
}