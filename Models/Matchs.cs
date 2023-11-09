namespace AppFutebol.Models;



public class Matchs
{
    public string Match_id { get; set; }
    public string Country_id { get; set; }
    public string Country_name { get; set; }
    public string League_id { get; set; }
    public string League_name { get; set; }
    public string Match_date { get; set; }
    public string Match_status { get; set; }
    public string Match_time { get; set; }
    public string Match_hometeam_id { get; set; }
    public string Match_hometeam_name { get; set; }
    public string Match_hometeam_score { get; set; }
    public string Match_awayteam_name { get; set; }
    public string Match_awayteam_id { get; set; }
    public string Match_awayteam_score { get; set; }
    public string Match_hometeam_halftime_score { get; set; }
    public string Match_awayteam_halftime_score { get; set; }
    public string Match_hometeam_extra_score { get; set; }
    public string Match_awayteam_extra_score { get; set; }
    public string Match_hometeam_penalty_score { get; set; }
    public string Match_awayteam_penalty_score { get; set; }
    public string Match_hometeam_ft_score { get; set; }
    public string Match_awayteam_ft_score { get; set; }
    public string Match_hometeam_system { get; set; }
    public string Match_awayteam_system { get; set; }
    public string Match_live { get; set; }
    public string Match_round { get; set; }
    public string Match_stadium { get; set; }
    public string Match_referee { get; set; }
    public string Team_home_badge { get; set; }
    public string Team_away_badge { get; set; }
    public string League_logo { get; set; }
    public string Country_logo { get; set; }
    public string League_year { get; set; }
    public string Fk_stage_key { get; set; }
    public string Stage_name { get; set; }

    public Goalscorer[] Goalscorer { get; set; }
}

public class Goalscorer
{
    public string Time { get; set; }
    public string Home_scorer { get; set; }
    public string Home_scorer_id { get; set; }
    public string Home_assist { get; set; }
    public string Home_assist_id { get; set; }
    public string Score { get; set; }
    public string Away_scorer { get; set; }
    public string Away_scorer_id { get; set; }
    public string Away_assist { get; set; }
    public string Away_assist_id { get; set; }
    public string Info { get; set; }
    public string Score_info_time { get; set; }
}

public class Cards
{
    public string Time { get; set; }
    public string Home_fault { get; set; }
    public string Card { get; set; }
    public string Away_fault { get; set; }
    public string Info { get; set; }
    public string Home_player_id { get; set; }
    public string Away_player_id { get; set; }
    public string Score_info_time { get; set; }
}

public class Substitutions
{
    public List<Home> Home { get; set; }
    public List<Away> Away { get; set; }
}

public class Home
{
    public string Time { get; set; }
    public string Substitution { get; set; }
    public string Substitution_player_id { get; set; }
}

public class Away
{
    public string Time { get; set; }
    public string Substitution { get; set; }
    public string Substitution_player_id { get; set; }
}

public class Lineup
{
    public Homes Home { get; set; }
    public Aways Away { get; set; }
}

public class Homes
{
    public List<StartingLineup> Starting_lineups { get; set; }
    public List<Substitute> Substitutes { get; set; }
    public List<Coach> Coach { get; set; }
    public List<object> Missing_players { get; set; }
}

public class Aways
{
    public List<StartingLineup> Starting_lineups { get; set; }
    public List<Substitute> Substitutes { get; set; }
    public List<Coach> Coach { get; set; }
    public List<object> Missing_players { get; set; }
}

public class StartingLineup
{
    public string Lineup_player { get; set; }
    public string Lineup_number { get; set; }
    public string Lineup_position { get; set; }
    public string Player_key { get; set; }
}

public class Substitute
{
    public string Lineup_player { get; set; }
    public string Lineup_number { get; set; }
    public string Lineup_position { get; set; }
    public string Player_key { get; set; }
}

public class Coach
{
    public string Lineup_player { get; set; }
    public string Lineup_number { get; set; }
    public string Lineup_position { get; set; }
    public string Player_key { get; set; }
}

public class Statistics
{
    public string Type { get; set; }
    public string Home { get; set; }
    public string Away { get; set; }
}

public class Statistics1Half
{
    public string Type { get; set; }
    public string Home { get; set; }
    public string Away { get; set; }
}
