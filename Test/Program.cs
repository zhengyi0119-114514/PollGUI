// See https://aka.ms/new-console-template for more information
using PollMgr;

// Console.WriteLine("Username:");
//String Username = Console.ReadLine()??String.Empty;
//Console.WriteLine("Password:");
//String Password = Console.ReadLine() ?? String.Empty;
//Console.WriteLine(await Account.RegisterAsync(name: Username, password: Password));

var result = await Account.GetAccountInfoAsync(@"eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJpc3MiOiJ5b3VyX2RvbWFpbi5jb20iLCJzdWIiOjE4LCJpYXQiOjE3NDA1MDE1NzgsImV4cCI6MTc0MDUwNTE3OCwiYWRtaW4iOmZhbHNlfQ.kq5M3ScLw8GrsonhgEqLJNwv-l0dQOB_JB-u2tQvlGbvJlnvu6Q_TnI7HfBAZoKyHT63v2xmg9jjVJI5DjqToA");
