using Sportify.Controller;
using Sportify.Model;

namespace Sportify.View;

public partial class RugbyLeaguesView : ContentPage
{
    private RugbyLeaguesController controller;

    public RugbyLeaguesView(RugbyLeague rugbyLeague)
	{
		InitializeComponent();
		controller = new(rugbyLeague);
        BindingContext = controller;   
	}

    private async void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        await controller.GetLeagues();
    }
}