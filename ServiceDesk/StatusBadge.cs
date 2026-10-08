using Avalonia;
using Avalonia.Controls.Primitives;

namespace ServiceDesk;

public class StatusBadge : TemplatedControl
{
    // Свойство «Статус» — строка
    public static readonly StyledProperty<string> StatusProperty =
        AvaloniaProperty.Register<StatusBadge, string>(nameof(Status), "Принята");

    public string Status
    {
        get => GetValue(StatusProperty);
        set => SetValue(StatusProperty, value);
    }

    // Свойство «Цвет фона» — кисть
    public static readonly StyledProperty<Avalonia.Media.IBrush?> BadgeBackgroundProperty =
        AvaloniaProperty.Register<StatusBadge, Avalonia.Media.IBrush?>(nameof(BadgeBackground));

    public Avalonia.Media.IBrush? BadgeBackground
    {
        get => GetValue(BadgeBackgroundProperty);
        set => SetValue(BadgeBackgroundProperty, value);
    }
}