using AppFutebol.Services;
using AppFutebol.ViewModels;

namespace AppFutebol;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        IServiceCollection services = new ServiceCollection();
        services.AddTransient<IRestService, RestService>();
        var serviceProvider = services.BuildServiceProvider();

        BindingContext = new MainViewModel(serviceProvider.GetService<IRestService>());
       
    }
}

