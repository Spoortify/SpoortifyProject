using Sportify.Controller;
namespace Sportify.View;

public partial class ViewSeasons : ContentPage
{
	public ViewSeasons()
	{
		InitializeComponent();
        var context = new ControllerSeasons();
        BindingContext = context;
        context.Start();
    }
}