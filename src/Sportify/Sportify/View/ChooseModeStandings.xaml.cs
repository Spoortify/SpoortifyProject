using Sportify.Controller;
using Sportify.Model;
using Sportify.View;

namespace Sportify.View;

public partial class ChooseModeStandings : ContentPage
{
	public ChooseModeStandings(int s, int l)
	{
		InitializeComponent();
        var context = new ControllerChooseModeStendings(s, l);
        BindingContext = context;
        context.Start();
    }
}