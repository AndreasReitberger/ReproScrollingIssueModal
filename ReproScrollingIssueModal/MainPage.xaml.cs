using ReproScrollingIssueModal.Views.Modals;

namespace ReproScrollingIssueModal;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private async void CounterBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(state: nameof(NewModalPage), animate: true);
    }
}

