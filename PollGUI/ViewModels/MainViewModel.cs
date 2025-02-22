using System;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.ComponentModel;
using PollGUI.Views;
using PollMgr;

namespace PollGUI.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public AccountInfo? Account{ get; set; } = new AccountInfo("SB");
}
