using Avalonia.Controls;

namespace PollGUI.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        View.LoginMenu.Click += async (s, e) =>
        {
            var window = new LoginWindow();
            await window.ShowDialog(this);
        };
        View.RegisterMenu.Click += async (s, e) =>
        {
            var window = new RegisterWindow();
            await window.ShowDialog(this);
        };
        View.AccountMenuItem.Click += async (s, e) =>
        {
            var window = new AccountWindow();
            await window.ShowDialog(this);
        };
    }
}