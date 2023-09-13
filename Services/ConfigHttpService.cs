using System.Text.Json;

namespace AppFutebol.Services;

public class ConfigHttpService
{
    public string Key { get; set; }
    public string Url { get; set; }

    public ConfigHttpService()
    {
        Key = "743afe74d926fec3721f37c41595da0fea5570182aa6ff6cb21ff257f07508ae";
        Url = "https://apiv3.apifootball.com/?action=get";

    }
}
