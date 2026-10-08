using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using ServiceDesk.Models;

namespace ServiceDesk.ViewModels;

public partial class RequestCardViewModel : ViewModelBase
{
    [ObservableProperty]
    private Request _currentRequest;

    public RequestCardViewModel(Request request)
    {
        CurrentRequest = request;
    }

    public RequestCardViewModel() : this(new Request
    {
        ClientName = "Нет данных",
        DeviceModel = "—",
        Description = "Заявка не создана",
        Status = "—",
        History = new List<string>(),
        Parts = new List<string>()
    }) { }
}