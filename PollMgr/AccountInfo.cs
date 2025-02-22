using System;
using Newtonsoft.Json;
namespace PollMgr;

public class AccountInfo(String name)
{
    public String Name { get; set; } = name;
    public String? Token { get; set; }
    public override string ToString()
    {
        return String.Format("Name: {0} Token:{1}", Name, Token);
    }
}
