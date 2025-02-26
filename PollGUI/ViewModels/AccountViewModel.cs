using System;
using PollMgr;

namespace PollGUI.ViewModels;

public class AccountViewModel : ViewModelBase
{
    public AccountViewModel()
    {
        this.AccountInfo = Static.Info;
        OnPropertyChanged();
        OnPropertyChanged(nameof(Name));
        OnPropertyChanged(nameof(Token));
        OnPropertyChanged(nameof(Id));
        OnPropertyChanged(nameof(IsAdmin));
        OnPropertyChanged(nameof(TotalAnwers));
        OnPropertyChanged(nameof(CorrectAnwers));
        OnPropertyChanged(nameof(WrongAnwers));
        OnPropertyChanged(nameof(LastActivity));
        OnPropertyChanged(nameof(Score));
    }
    private AccountInfo m_AccountInfo = new("String.Empty");
    public String Name
    {
        get { return m_AccountInfo.Name; }
        set
        {
            this.m_AccountInfo.Name = value;
            this.OnPropertyChanged();
        }
    }
    public String? Token
    {
        get { return m_AccountInfo.Token; }
        set
        {
            this.m_AccountInfo.Token = value;
            this.OnPropertyChanged();
        }
    }
    public Int32 Id
    {
        get => m_AccountInfo.Id; set
        {
            this.m_AccountInfo.Id = value;
            OnPropertyChanged();
        }
    }
    public bool IsAdmin
    {
        get => m_AccountInfo.IsAdmin; set
        {
            m_AccountInfo.IsAdmin = value;
            OnPropertyChanged();
        }
    }
    public Int32 TotalAnwers
    {
        get => m_AccountInfo.TotalAnwers; set
        {
            m_AccountInfo.TotalAnwers = value;
            OnPropertyChanged();
        }
    }
    public Int32 CorrectAnwers
    {
        get => AccountInfo.CorrectAnwers; set
        {
            AccountInfo.CorrectAnwers = value;
            OnPropertyChanged();
        }
    }
    public Int32 WrongAnwers
    {
        get => AccountInfo.WrongAnwers; set
        {
            AccountInfo.WrongAnwers = value;
            OnPropertyChanged();
        }
    }
    public DateTime LastActivity
    {
        get => AccountInfo.LastActivity; set
        {
            AccountInfo.LastActivity = value;
            OnPropertyChanged();
        }
    }
    public Int32 Score
    {
        get => AccountInfo.Score; set
        {
            AccountInfo.Score = value;
            OnPropertyChanged();
        }
    }
    public AccountInfo AccountInfo
    {
        get
        {
            return m_AccountInfo;
        }
        set
        {
            m_AccountInfo = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Token));
            OnPropertyChanged(nameof(Id));
            OnPropertyChanged(nameof(IsAdmin));
            OnPropertyChanged(nameof(TotalAnwers));
            OnPropertyChanged(nameof(CorrectAnwers));
            OnPropertyChanged(nameof(WrongAnwers));
            OnPropertyChanged(nameof(LastActivity));
            OnPropertyChanged(nameof(Score));
        }
    }

}
