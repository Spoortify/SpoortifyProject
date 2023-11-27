using Sportify.Controller;
namespace Sportify.View;
public partial class ViewGamesResponse : ContentPage
{
	public ViewGamesResponse()
	{
		InitializeComponent();
		var context = new BaseballController();
		BindingContext = context;
		context.Start();
	}
}