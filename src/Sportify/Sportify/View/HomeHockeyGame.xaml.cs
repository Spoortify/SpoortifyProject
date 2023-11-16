using Sportify.Controller;

namespace Sportify.View;

public partial class HomeHockeyGame : ContentPage
{
	public HomeHockeyGame()
	{
		InitializeComponent();
		HomeHockeyGameController controller = new HomeHockeyGameController();
		BindingContext = controller;
	}
}