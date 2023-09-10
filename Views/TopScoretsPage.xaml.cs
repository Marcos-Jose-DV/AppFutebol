using AppFutebol.ViewModels;

namespace AppFutebol.Views;

public partial class TopScoretsPage : ContentPage
{
	public TopScoretsPage()
	{
		InitializeComponent();

		BindingContext = new TopScoretsViewModel();

    }
}