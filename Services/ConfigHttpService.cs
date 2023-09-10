using System.Text.Json;

namespace AppFutebol.Services;

public class ConfigHttpService
{
    public string Key { get; set; }
    public string Url { get; set; }

    public ConfigHttpService()
    {
        Key = "";
        Url = "https://apiv3.apifootball.com/?action=get";

    }
}
