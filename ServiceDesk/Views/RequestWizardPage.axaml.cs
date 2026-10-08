using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.VisualTree;
using ServiceDesk.Models;
using ServiceDesk.ViewModels;
using ServiceDesk.Views.Wizard;

namespace ServiceDesk.Views;

public partial class RequestWizardPage : NavigationPage
{
    private RequestWizardViewModel ViewModel => (RequestWizardViewModel)DataContext!;

    public RequestWizardPage()
    {
        InitializeComponent();
        DataContext = new RequestWizardViewModel();
    }


    private async void GoToStep2_Click(object? sender, RoutedEventArgs e)
    {
        var step2View = new Step2DeviceView { DataContext = ViewModel };

        var nextButton = new Button
        {
            Content = "Далее →",
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Avalonia.Thickness(20)
        };
        nextButton.Click += GoToStep3_Click;

        var panel = new DockPanel();
        DockPanel.SetDock(nextButton, Dock.Bottom);
        panel.Children.Add(nextButton);
        panel.Children.Add(step2View);

        await PushAsync(new ContentPage
        {
            Header = "Шаг 2: Устройство",
            Content = panel
        });
    }

    private async void GoToStep3_Click(object? sender, RoutedEventArgs e)
    {
        var step3View = new Step3CostView { DataContext = ViewModel };

        var finishButton = new Button
        {
            Content = "✓ Завершить",
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Avalonia.Thickness(20)
        };
        finishButton.Click += Finish_Click;

        var panel = new DockPanel();
        DockPanel.SetDock(finishButton, Dock.Bottom);
        panel.Children.Add(finishButton);
        panel.Children.Add(step3View);

        await PushAsync(new ContentPage
        {
            Header = "Шаг 3: Стоимость и срок",
            Content = panel
        });
    }


    private void Finish_Click(object? sender, RoutedEventArgs e)
    {
        var vm = (RequestWizardViewModel)DataContext!;

        // Создаём заявку из данных мастера
        var request = new Request
        {
            Id = 1,
            ClientName = string.IsNullOrWhiteSpace(vm.ClientName) ? "Иванов И.И." : vm.ClientName,
            DeviceModel = string.IsNullOrWhiteSpace(vm.DeviceModel) ? "Samsung S21" : vm.DeviceModel,
            Description = string.IsNullOrWhiteSpace(vm.Description) ? "Не включается" : vm.Description,
            Status = "Принята",
            History = new List<string>
            {
                $"{DateTime.Now:dd.MM.yyyy} — Заявка создана",
                $"{DateTime.Now:dd.MM.yyyy} — Передана мастеру"
            },
            Parts = new List<string>
            {
                "Экран — 3000 ₽",
                "Аккумулятор — 1500 ₽",
                "Шлейф — 800 ₽"
            }
        };


        var mainView = this.FindAncestorOfType<MainView>();
        if (mainView != null)
        {
            mainView.ShowRequestCard(request);
        }
        else
        {
 
            var topLevel = TopLevel.GetTopLevel(this);
            var mv = topLevel?.FindDescendantOfType<MainView>();
            mv?.ShowRequestCard(request);
        }
    }
}