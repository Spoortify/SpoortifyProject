using Sportify.Controller;
namespace Sportify.View;

public partial class ViewStandings : ContentPage
{
	public ViewStandings(int s, int l)
	{
		InitializeComponent();
        var context = new ControllerChooseModeStendings(s, l);
        BindingContext = context;
        context.Start();
    }
}