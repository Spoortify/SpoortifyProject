using Sportify.Controller;
using Sportify.Model;

namespace Sportify.View;

public partial class RugbyGameDetails : ContentPage
{
	public RugbyGameDetails(RugbyGameResponse rugbyGame)
	{
		InitializeComponent();
		RugbyGameDetailsController controller = new(rugbyGame);
		BindingContext = controller;
	}
}