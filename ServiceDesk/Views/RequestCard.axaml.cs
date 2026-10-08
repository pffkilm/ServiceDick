using Avalonia;
using Avalonia.Controls;

namespace ServiceDesk.Views;

public partial class RequestCard : UserControl
{

    public static readonly StyledProperty<string> RequestNumberProperty =
        AvaloniaProperty.Register<RequestCard, string>(nameof(RequestNumber), "№123");

    public static readonly StyledProperty<string> ClientNameProperty =
        AvaloniaProperty.Register<RequestCard, string>(nameof(ClientName), "Иванов И.И.");

    public static readonly StyledProperty<string> StatusProperty =
        AvaloniaProperty.Register<RequestCard, string>(nameof(Status), "В работе");

    public static readonly StyledProperty<int> ProgressProperty =
        AvaloniaProperty.Register<RequestCard, int>(nameof(Progress), 60);


    public string RequestNumber
    {
        get => GetValue(RequestNumberProperty);
        set => SetValue(RequestNumberProperty, value);
    }

    public string ClientName
    {
        get => GetValue(ClientNameProperty);
        set => SetValue(ClientNameProperty, value);
    }

    public string Status
    {
        get => GetValue(StatusProperty);
        set => SetValue(StatusProperty, value);
    }

    public int Progress
    {
        get => GetValue(ProgressProperty);
        set => SetValue(ProgressProperty, value);
    }

    public RequestCard()
    {
        InitializeComponent();
    }
}