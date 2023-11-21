using Sportify.Controller;

namespace Sportify.View;

public partial class HomeHockeyGame : ContentPage
{
	public HomeHockeyGame()
	{
        InitializeComponent();
		HomeHockeyGameController controller = new HomeHockeyGameController();
		BindingContext = controller;

        //BindingContext = new HomeHockeyGameController();
	}
    protected override void OnAppearing()
    {
        _ = HomeHockeyGameController.ShowGames();
    }

    private async void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        await HomeHockeyGameController.ShowGames();
    }
}