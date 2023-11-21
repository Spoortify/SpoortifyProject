using Sportify.Controller;
using Sportify.Model;

namespace Sportify.View;

public partial class FootballTopScorerDetails : ContentPage
{
	private FootballTopScorerDetailsController controller;
	public FootballTopScorerDetails(FootballTopScorersResponse topScorer)
	{
		InitializeComponent();
		controller = new(topScorer);
		BindingContext = controller;
	}
}