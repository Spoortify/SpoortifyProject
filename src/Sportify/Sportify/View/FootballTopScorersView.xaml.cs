using Sportify.Controller;

namespace Sportify.View;

public partial class FootballTopScorersView : ContentPage
{
	private FootballTopScorersController controller;
	public FootballTopScorersView(string season, int leagueId)
	{
		InitializeComponent();
		controller = new(season, leagueId);
		BindingContext = controller;
	}
}