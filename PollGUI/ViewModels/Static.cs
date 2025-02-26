using System;
using System.Threading;
using System.Xml.Linq;
using PollMgr;

namespace PollGUI.ViewModels;

public static class Static
{
    private static AccountInfo m_Info = new("NULL");
    public static event EventHandler? OnInfoChange;
    public static AccountInfo Info
    {
        get
        {
            return m_Info;
        }
        set
        {
            m_Info = value;
            var e = Volatile.Read(ref OnInfoChange);
            e?.Invoke(null,new());
        }
    }
    public static String UserName = String.Empty;
    public static String Password = String.Empty;
    public static Timer? Timer;
    public static void StartServie()
    {
        Static.Timer = new(async (state) =>
        {
            String token = await Account.LoginAsync(UserName, Password);
            Static.Info = new(Static.UserName)
            {
                Token = token
            };
        }, null,3500 * 1000, 3500 * 1000);
    }
}
