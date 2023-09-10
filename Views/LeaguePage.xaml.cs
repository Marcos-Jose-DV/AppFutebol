using AppFutebol.ViewModels;

namespace AppFutebol.Views;

public partial class LeaguePage : ContentPage
{
	public LeaguePage()
	{
		InitializeComponent();

		BindingContext = new LeagueViewModel(); 
	}
}