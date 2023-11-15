using Sportify.Controller;
using Sportify.Model;

namespace Sportify.View;

public partial class RugbyLeagueStandings : ContentPage
{
    public RugbyLeagueStandings(RugbyLeagueStandingsModel rugbyLeagueStandings)
	{
		InitializeComponent();
        RugbyLeagueStandingsController controller = new(rugbyLeagueStandings);
        BindingContext = controller;
    }
}