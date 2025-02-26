using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MsBox.Avalonia;
using PollGUI.ViewModels;
using PollMgr;
using System;
using System.Text;

namespace PollGUI.Views;

public partial class RegisterWindow : Window
{
    public RegisterWindow()
    {
        InitializeComponent();
        View.OkButton.Click += async (s, e) => 
        {
            string name = View.UserNameTextBox.Text ?? string.Empty;
            string password = View.PasswordTextBox.Text ?? string.Empty;
            String passwoed2 = View.PasswordTextBox2.Text ?? string.Empty;
            if(!String.Equals(passwoed2,password,StringComparison.Ordinal))
            {
                var messageBox = MessageBoxManager.GetMessageBoxStandard("Error", "两次输入的密码不一样捏！");
                await messageBox.ShowAsync();
                return;
            }
            try
            {
                var token = await Account.RegisterAsync(name, password);
            }
            catch(AccountException ex)
            {
                var messageBox = MessageBoxManager.GetMessageBoxStandard("Error", ex.Message);
                await messageBox.ShowAsync();
                return;
            }
            Static.UserName = name;
            Static.Password = password;
            Static.StartServie();
            this.Close();
        };
        View.ClearButton.Click += (s, e) =>
        {
            this.Close();
        };
    }
}