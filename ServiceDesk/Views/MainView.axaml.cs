using Avalonia.Controls;
using Avalonia.Interactivity;
using ServiceDesk.Models;
using ServiceDesk.ViewModels;

namespace ServiceDesk.Views;

public partial class MainView : DrawerPage
{
    public MainView()
    {
        InitializeComponent();
    }


    private void OpenDrawer_Click(object? sender, RoutedEventArgs e)
    {
        IsOpen = true;
    }

    
    private void MenuList_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (MenuList.SelectedIndex == -1) return;
        ContentTabs.SelectedIndex = MenuList.SelectedIndex;
        IsOpen = false;
        MenuList.SelectedIndex = -1;
    }


    private void OnReportClick(object? sender, RoutedEventArgs e)
    {
        new ReportWindow().Show();
    }


    public void ShowRequestCard(Request request)
    {
        ContentTabs.SelectedIndex = 3;
        if (ContentTabs.SelectedItem is TabItem tab &&
            tab.Content is RequestCardPage cardPage)
        {
            cardPage.DataContext = new RequestCardViewModel(request);
        }
    }
}