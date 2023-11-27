using Sportify.Controller;
namespace Sportify.View;

public partial class SeasonsDetails : ContentPage
{
	public SeasonsDetails(int season)
	{
		InitializeComponent();
        var context = new ControllerSeasonDetails(season);
        BindingContext = context;
        context.Start();
    }
}