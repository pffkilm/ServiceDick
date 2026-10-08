using CommunityToolkit.Mvvm.ComponentModel;

namespace ServiceDesk.ViewModels;

public partial class RequestWizardViewModel : ViewModelBase
{
    [ObservableProperty] private string _clientName = string.Empty;
    [ObservableProperty] private string _phone = string.Empty;
    [ObservableProperty] private string _deviceModel = string.Empty;
    [ObservableProperty] private string _description = string.Empty;
    [ObservableProperty] private string _cost = string.Empty;
    [ObservableProperty] private string _days = string.Empty;
}