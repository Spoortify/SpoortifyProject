using Sportify.Controller;
using Sportify.Model;

namespace Sportify.View;

public partial class NbaPlayerSeasonStatisticsView : ContentPage
{
	public NbaPlayerSeasonStatisticsView(NBARoasterResponse response, int season)
	{
		InitializeComponent();
		NbaPlayerSeasonStatisticsController controller = new NbaPlayerSeasonStatisticsController(response, season);
		BindingContext = controller;
	}
}