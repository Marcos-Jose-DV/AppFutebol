using AppFutebol.Controlls;
using AppFutebol.Models;
using AppFutebol.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

namespace AppFutebol.ViewModels;

public partial class LeagueViewModel : ObservableObject
{
  

    [ObservableProperty]
    public Standings[] _standings;
    [ObservableProperty]
    private bool _isBusy = true;

    [ObservableProperty]
    private string _league;


    public LeagueViewModel()
    {
       
    }

}
