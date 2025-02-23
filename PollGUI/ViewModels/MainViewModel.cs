using System;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.ComponentModel;
using PollGUI.Views;
using PollMgr;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PollGUI.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        // Login = new Command
    }
    private AccountInfo m_AccountInfo = new("SB");
    public AccountInfo AccountInfo
    {
        get { return m_AccountInfo; }
        set
        {
            OnPropertyChanged(nameof(AccountInfo));
            OnPropertyChanged(nameof(IsLogin));
            m_AccountInfo = value;
        }
    }
    public Boolean IsLogin
    {
        get { return m_AccountInfo.Token != null; }
        set { }
    }
    
    public ICommand Login { get; init; }
    public ICommand Logout { get; init;}
    public ICommand Register { get; init; }
}
