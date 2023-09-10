using AppFutebol.Controlls;
using AppFutebol.Models;
using AppFutebol.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

namespace AppFutebol.ViewModels;

public partial class LeagueViewModel : ObservableObject
{
    private readonly ConfigHttpService _config;
    HttpClient _client;
    JsonSerializerOptions _JsonSerializer;

    [ObservableProperty]
    public Standings[] _standings;
    [ObservableProperty]
    private bool _isBusy = true;

    [ObservableProperty]
    private string _league;


    public LeagueViewModel()
    {
        _config = new ConfigHttpService();

        _client = new HttpClient();

        _JsonSerializer = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        GetStandingsAsync();
    }

    private async Task GetStandingsAsync()
    {
        try
        {
            var url = $"{_config.Url}_standings&league_id=99&APIkey={_config.Key}";
            var response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var data = await JsonSerializer.DeserializeAsync<Standings[]>(responseStream, _JsonSerializer);
                Standings = data;

                ColorsControll.SetColor(Standings);

                League = data.Select(league => league.League_name).First().ToString();

            }
        }
        catch (Exception ex)
        {
            ex.ToString();
        }
        finally
        {
            IsBusy = false;

        }
    }
}
