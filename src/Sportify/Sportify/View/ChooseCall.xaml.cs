namespace Sportify.View;

public partial class ChooseCall : ContentPage
{
	public ChooseCall()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Button b = (Button)sender;
		int var = int.Parse(b.Text);
		switch (var)
		{	
			case 1:
				App.Current.MainPage.Navigation.PushAsync(new ViewGamesResponse());
				break;
			case 2:
				App.Current.MainPage.Navigation.PushAsync(new ViewSeasons());
				break;
			case 3:
				
				break;
			case 4:
				break;
			case 5: 
				break;
			default: 
				break;
		}
	}
}