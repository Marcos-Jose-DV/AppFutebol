using AppFutebol.Controlls;
using AppFutebol.Models;
using AppFutebol.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Graphics.Text;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;

namespace AppFutebol.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly ConfigHttpService _config;
    HttpClient _client;
    JsonSerializerOptions _JsonSerializer;

    [ObservableProperty]
    public MatchInfo[] _match;

    [ObservableProperty]
    private bool _isBusy = true;

    [ObservableProperty]
    private string _day,_mes, _date, _dateNow;

    public ICommand BackDayCommand
        => new Command(async () => await BackDay());

    public ICommand NextDayCommand
        => new Command(async () => await NextDay());



    public MainViewModel()
    {
        _config = new ConfigHttpService();
        _client = new HttpClient();
        _JsonSerializer = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        GetMatchInfoAsync(DateTime.Now.ToString("yyyy-MM-dd"));
    }

    private async Task BackDay()
    {
        Match = null;
        var date = DateTime.Parse(DateNow).AddDays(-1);
        await GetMatchInfoAsync(date.ToString("yyyy-MM-dd"));
    }
    private async Task NextDay()
    {
        Match = null;
        var date = DateTime.Parse(DateNow).AddDays(1);
        await GetMatchInfoAsync(date.ToString("yyyy-MM-dd"));
    }

    private async Task GetMatchInfoAsync(string date)
    {
        try
        {
            IsBusy = true;
            Date = Convert.ToString(DateTime.Parse(date).Day);
            DateNow = date;
            Mes = Convert.ToString(DateTime.Parse(date).ToString("MM-yyyy"));
            Day = DayControll.GetDayPtBR(DateTime.Parse(date));

            var url = $"{_config.Url}_events&from={DateNow}&to={DateNow}&league_id=99&APIkey={_config.Key}&timezone=America/Sao_Paulo";
            var response = await _client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var data = await JsonSerializer.DeserializeAsync<MatchInfo[]>(responseStream, _JsonSerializer);
                Match = data;
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

