using Sportify.Controller;
using Sportify.Model;

namespace Sportify.View;

public partial class RugbyLeagues : ContentPage
{
	public RugbyLeagues(RugbyLeague rugbyLeague)
	{
		InitializeComponent();
		RugbyLeaguesController controller = new(rugbyLeague);
        BindingContext = controller;   
	}

    private async void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        await RugbyLeaguesController.GetLeagues();
    }
}