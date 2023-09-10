using static AppFutebol.Models.League;

namespace AppFutebol.Models;

public class Team
{
    public string Team_key { get; set; }
    public string Team_name { get; set; }
    public string Team_badge { get; set; }
    public List<Players> Players { get; set; }
    public List<Coache> Coaches { get; set; }

}

