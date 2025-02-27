using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace PollGUI.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    public async void AboutServiceClick(object sender, RoutedEventArgs args)
    {
        var launcher = TopLevel.GetTopLevel(this)?.Launcher;
        var task =launcher?.LaunchUriAsync(new("https://api.jmxhyz.site/index.html"));
        if(task != null)
        {
            await task;
        }
    }
    private void AboutAppMenuClick(object sender, RoutedEventArgs args)
    {
        new AboutWindow().Show();
    }
    private async void AboutWebClick(Object s,RoutedEventArgs e)
    {
        var launcher = TopLevel.GetTopLevel(this)?.Launcher;
        var task = launcher?.LaunchUriAsync(new("https://demo.jmxhyz.site/"));
        if (task != null)
        {
            await task;
        }
    }
}