using Sportify.Controller;

namespace Sportify.View;

public partial class ViewTeams : ContentPage
{
	public ViewTeams(int s, int l)
	{
		InitializeComponent();
        var context = new ControllerTeams(s, l);
        BindingContext = context;
        context.Start();
    }
}