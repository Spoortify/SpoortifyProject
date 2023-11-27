using Sportify.Controller;

namespace Sportify.View;

public partial class FootballStandings : ContentPage
{
	private FootballStandingsController controller;
	public FootballStandings()
	{
		InitializeComponent();
		controller = new();
		BindingContext = controller;
	}
}