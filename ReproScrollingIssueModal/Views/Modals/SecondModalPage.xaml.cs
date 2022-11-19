namespace ReproScrollingIssueModal.Views.Modals;

public partial class SecondModalPage : ContentPage
{
	public SecondModalPage()
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
        Shell.Current.GoToAsync("..");
    }
}