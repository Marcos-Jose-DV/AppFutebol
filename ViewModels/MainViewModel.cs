using AppFutebol.Controlls;
using AppFutebol.Models;
using AppFutebol.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using AppFutebol.Constants;

namespace AppFutebol.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IRestService _service;

    [ObservableProperty]
    public Matchs[] _matchs;

    [ObservableProperty]
    private bool _isBusy = true;

    [ObservableProperty]
    private string _day, _mes, _date, _dateNow;

    public ICommand BackDayCommand
        => new Command(BackDay);

    public ICommand NextDayCommand
        => new Command(NextDay);

    public ICommand SearchCommand
        => new Command(Search);

    
    public MainViewModel(IRestService service)
    {
        _service = service;
        NewDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
    }
    private void Search()
    {
        throw new NotImplementedException();
    }

    private void BackDay()
    {
        Matchs = null;
        var date = DateTime.Parse(DateNow).AddDays(-1);
        NewDateTime(date.ToString("yyyy-MM-dd"));
    }
    private void NextDay()
    {
        Matchs = null;
        var date = DateTime.Parse(DateNow).AddDays(1);
        NewDateTime(date.ToString("yyyy-MM-dd"));
    }

    private void NewDateTime(string date)
    {
        Date = Convert.ToString(DateTime.Parse(date).Day);
        DateNow = date;
        Mes = Convert.ToString(DateTime.Parse(date).ToString("MM-yyyy"));
        Day = DayControll.GetDayPtBR(DateTime.Parse(date));
        IsBusy = true;
        GetStandingsData();
    }

    private async Task<Task> GetStandingsData()
    {
        try
        {
            Matchs[] match = await _service.GetMatchData(GenerateRequestURL(Constant.Opefootball));
            Matchs = match;
        }
        finally
        {
            IsBusy = false;
        }

        return Task.CompletedTask;
    }

    private string GenerateRequestURL(string endPoint)
    {
        string requestUri = endPoint;
        requestUri += $"_events";
        requestUri += $"&from={DateNow}";
        requestUri += $"&to={DateNow}";
        requestUri += $"&country_id=27";
        requestUri += $"&APIkey={Constant.OpeFootballKey}";
        requestUri += $"&timezone=America/Sao_Paulo";

        return requestUri;
    }
}

