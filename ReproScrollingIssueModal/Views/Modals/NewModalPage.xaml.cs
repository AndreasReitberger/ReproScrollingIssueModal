namespace ReproScrollingIssueModal.Views.Modals;

public partial class NewModalPage : ContentPage
{
	public NewModalPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        // Set breakpoint here for both modals
        base.OnAppearing();
        try
        {

        }
        catch (Exception) { }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(SecondModalPage));
    }
}