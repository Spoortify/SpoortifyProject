using Sportify.Controller;
using Sportify.Model;

namespace Sportify.View;

public partial class NbaTeamsStatisticsView : ContentPage
{
	public NbaTeamsStatisticsView(NBAResponse response)
	{
		InitializeComponent();
		NbaTeamsStatisticsController controller = new NbaTeamsStatisticsController(response);
		BindingContext = controller;
	}
}