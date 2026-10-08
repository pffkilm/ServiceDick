using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ServiceDesk.Views;

public partial class ReportWindow : Window
{
    public ReportWindow()
    {
        InitializeComponent();
    }

    private void Close_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}