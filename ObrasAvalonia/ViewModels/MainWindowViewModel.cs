namespace ObrasAvalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static
        // Add a property of type SettingsViewModel
        public SettingsViewModel Settings { get; private set; }

        public MainWindowViewModel()
        {
            // Initialize the SettingsViewModel
            Settings = new SettingsViewModel();

            // Other initialization if necessary
        }
    }
}
