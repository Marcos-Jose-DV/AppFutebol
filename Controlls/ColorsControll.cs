using AppFutebol.Models;
using System.Globalization;

namespace AppFutebol.Controlls;

public static class ColorsControll
{
    private static Color GetColor(string pts)
    {
        var PTS = Convert.ToInt32(pts);

        Color color = PTS switch
        {
            <= 4 => ConvertFrom("#4285F4"),
            <= 6 => ConvertFrom("#FA7B17"),
            <= 12 => ConvertFrom("#34A853"),
            <= 16 => ConvertFrom("#FFFFFF"),
            >= 17 => ConvertFrom("#EA4335"),
        };

        return color;
    }

    public static void SetColor(Standings[] standings)
    {
        foreach (var item in standings)
        {
            item.BgColor = GetColor(item.Overall_league_position);
        }

    }
    private static Color ConvertFrom(string value)
        => Color.FromArgb(value);
}
