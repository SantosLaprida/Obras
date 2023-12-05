using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ObrasAvalonia.Views;
using System.Globalization;

namespace ObrasAvalonia;

public partial class TopMenu : UserControl
{
    public TopMenu()
    {
        InitializeComponent();
    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

}