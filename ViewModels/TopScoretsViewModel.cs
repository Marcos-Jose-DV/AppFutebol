

using AppFutebol.Controlls;
using AppFutebol.Models;
using AppFutebol.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

namespace AppFutebol.ViewModels;

public partial class TopScoretsViewModel : ObservableObject
{
    private readonly ConfigHttpService _config;
    HttpClient _client;
    JsonSerializerOptions _JsonSerializer;

    [ObservableProperty]
    public TopScorets[] _top;
    [ObservableProperty]
    private bool _isBusy = true;

    public TopScoretsViewModel()
    {
        _config = new ConfigHttpService();

        _client = new HttpClient();

        _JsonSerializer = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        GetLeagueAsync();
    }

  
    private async Task GetLeagueAsync()
    {
        try
        {
            var url = $"{_config.Url}_topscorers&league_id=99&APIkey={_config.Key}";
            var response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var data = await JsonSerializer.DeserializeAsync<TopScorets[]>(responseStream, _JsonSerializer);
                Top = data;
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

