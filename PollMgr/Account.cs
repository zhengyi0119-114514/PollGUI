using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
namespace PollMgr;

public static class Account
{
    public static Uri BaseUri
    {
        get
        {
            return new Uri("https://api.jmxhyz.site/");
        }
    }
    public static async Task<String> Register(string name, string password)
    {
        RestClient client = new(BaseUri);
        RestRequest request = new("api/register", Method.Post)
        {
            RequestFormat = DataFormat.Json,
        };
        request.AddJsonBody(new { username = name, password = password });
        var result = await client.ExecuteAsync(request);
        JObject obj = JObject.Parse(result.Content ?? String.Empty);
        Int32 code = Int32.Parse(obj["code"]?.ToString() ?? "0");
        if (code != 200)
        {
            String message = obj["message"]?.ToString()??String.Empty;
            throw code switch
            {
                0 => new AccountException(message,AccountExceptionType.Network),
                409 => new AccountException(message,AccountExceptionType.Exist),
                _ => new AccountException(message)
            };
        }
        else
        {
            return obj["data"]!["token"]!.ToString();
        }

    }
    public static async Task<String> Login(string username, string password)
    {
        RestClient client = new(BaseUri);
        RestRequest request = new("api/login", Method.Post)
        {
            RequestFormat = DataFormat.Json
        };
        request.AddJsonBody(new { username = username, password = password });
        var result = await client.ExecuteAsync(request);
        JObject obj = JObject.Parse(result.Content ?? String.Empty);
        Int32 code = Int32.Parse(obj["code"]?.ToString() ?? "0");
        if (code != 200)
        {
            String message = obj["message"]?.ToString()??String.Empty;
            throw code switch
            {
                0 => new AccountException(message, AccountExceptionType.Network),
                401 => new AccountException(message, AccountExceptionType.NotFound),
                _ => new AccountException(message, AccountExceptionType.Unknown),
            };
        }
        else
        {
            return obj["data"]!["token"]!.ToString();
        }
    }

}

