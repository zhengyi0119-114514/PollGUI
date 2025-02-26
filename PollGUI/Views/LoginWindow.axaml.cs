using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MsBox.Avalonia;
using PollGUI.ViewModels;
using PollMgr;

namespace PollGUI.Views;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
        View.OkButton.Click += async (o, e) =>
        {
            String name = View.NameTextBox.Text ?? String.Empty;
            String password = View.PasswordTextBox.Text ?? String.Empty;
            Static.Info.Name = name;
            Static.Password = password;
            try
            {
                var token = await Account.LoginAsync(name, password);
                Static.Info = new(name) { Token = token };
            }
            catch(AccountException ex)
            {
                var messageBox = MessageBoxManager.GetMessageBoxStandard("",$"{ex.Message}");
                await messageBox.ShowAsync();
                return;
            }
            this.Close();
        };
        View.ClearButton.Click +=
        (o, e) =>
        {
            this.Close();
        };
    }
}