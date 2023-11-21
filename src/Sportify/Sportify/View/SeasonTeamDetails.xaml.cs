using Sportify.Controller;
using Sportify.Model;

namespace Sportify.View;

public partial class SeasonTeamDetails : ContentPage
{
	public SeasonTeamDetails(FootballStandingsModel team)
	{
		InitializeComponent();
		SeasonTeamDetailsController controller = new(team);
		BindingContext = controller;
	}
}