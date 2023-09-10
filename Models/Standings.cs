namespace AppFutebol.Models;

public class Standings
{
    public string Country_name { get; set; }
    public string League_id { get; set; }
    public string League_name { get; set; }
    public string Team_id { get; set; }
    public string Team_name { get; set; }
    public string Overall_promotion { get; set; }
    public string Overall_league_position { get; set; }
    public string Overall_league_payed { get; set; }
    public string Overall_league_W { get; set; }
    public string Overall_league_D { get; set; }
    public string Overall_league_L { get; set; }
    public string Overall_league_GF { get; set; }
    public string Overall_league_GA { get; set; }
    public string Overall_league_PTS { get; set; }
    public string Home_league_position { get; set; }
    public string Home_promotion { get; set; }
    public string Home_league_payed { get; set; }
    public string Home_league_W { get; set; }
    public string Home_league_D { get; set; }
    public string Home_league_L { get; set; }
    public string Home_league_GF { get; set; }
    public string Home_league_GA { get; set; }
    public string Home_league_PTS { get; set; }
    public string Away_league_position { get; set; }
    public string Away_promotion { get; set; }
    public string Away_league_payed { get; set; }
    public string Away_league_W { get; set; }
    public string Away_league_D { get; set; }
    public string Away_league_L { get; set; }
    public string Away_league_GF { get; set; }
    public string Away_league_GA { get; set; }
    public string Away_league_PTS { get; set; }
    public string League_round { get; set; }
    public string Team_badge { get; set; }
    public string Fk_stage_key { get; set; }
    public string Stage_name { get; set; }

    public Color BgColor { get; set; }
}
