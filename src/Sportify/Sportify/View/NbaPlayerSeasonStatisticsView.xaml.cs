using Sportify.Controller;
using Sportify.Model;

namespace Sportify.View;

public partial class NbaPlayerSeasonStatisticsView : ContentPage
{
	public NbaPlayerSeasonStatisticsView(List<NBAResponse> response)
	{
		InitializeComponent();
		NbaPlayerSeasonStatisticsController controller = new NbaPlayerSeasonStatisticsController(response);
		BindingContext = controller;
	}
}