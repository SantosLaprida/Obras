using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ObrasAvalonia.Views
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve user input
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string selectedLanguage = ((ComboBoxItem)LanguageComboBox.SelectedItem)?.Content.ToString();

            // TODO: Validate username and password
            // TODO: Set application culture based on selected language
            // Example:
            // CultureInfo.CurrentCulture = new CultureInfo(selectedLanguage == "Español" ? "es-ES" : "en-US");
            // CultureInfo.CurrentUICulture = new CultureInfo(selectedLanguage == "Español" ? "es-ES" : "en-US");

            // TODO: Close this window and open the main window
        }
    }
}
