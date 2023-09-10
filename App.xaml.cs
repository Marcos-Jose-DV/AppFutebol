using AppFutebol.Views;

namespace AppFutebol;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
