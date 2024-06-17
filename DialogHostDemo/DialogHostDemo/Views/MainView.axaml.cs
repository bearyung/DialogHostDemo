using Avalonia.Controls;
using Avalonia.Interactivity;
using DialogHostAvalonia;
using DialogHostDemo.ViewModels;

namespace DialogHostDemo.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        DialogHost.Show(new DialogDemoContentViewModel());

    }
}