using System;
using PollMgr;

namespace PollGUI.ViewModels;

public class AccountViewModel : ViewModelBase
{
    private AccountInfo m_AccountInfo = new("String.Empty");
    public String Name
    {
        get { return m_AccountInfo.Name; }
        set
        {
            this.OnPropertyChanged();
            this.m_AccountInfo.Name = value;
        }
    }
    public String? Token
    {
        get { return m_AccountInfo.Token; }
        set
        {
            this.OnPropertyChanged();
            this.m_AccountInfo.Token = value;
        }
    }
    
}
