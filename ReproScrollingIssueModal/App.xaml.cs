using ReproScrollingIssueModal.Views.Modals;

namespace ReproScrollingIssueModal;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        Routing.RegisterRoute(nameof(NewModalPage), typeof(NewModalPage));
    }
}
