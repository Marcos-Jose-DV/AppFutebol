

using AppFutebol.Controlls;
using AppFutebol.Models;
using AppFutebol.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

namespace AppFutebol.ViewModels;

public partial class TopScoretsViewModel : ObservableObject
{
   

    [ObservableProperty]
    public TopScorets[] _top;
    [ObservableProperty]
    private bool _isBusy = true;

    public TopScoretsViewModel()
    {
       
    }
}

