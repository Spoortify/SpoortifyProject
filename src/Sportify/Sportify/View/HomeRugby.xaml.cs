using Sportify.Controller;

namespace Sportify.View;

public partial class HomeRugby : ContentPage
{
	public HomeRugby()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        HomeRugbyController.ShowGames();
    }

    private async void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        await HomeRugbyController.ShowGames();
    }

}