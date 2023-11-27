using Sportify.Model;
using Sportify.Controller;

namespace Sportify.View;

public partial class NbaSeasonRoasterView : ContentPage
{
	public NbaSeasonRoasterView(List<NBAResponse> response)
	{
		InitializeComponent();
		NbaSeasonRoasterController controller = new NbaSeasonRoasterController(response);
		BindingContext = controller;
	}
}