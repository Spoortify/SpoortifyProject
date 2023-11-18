using CommunityToolkit.Mvvm.Input;

namespace Sportify.View;

public partial class ChooseCall : ContentPage
{
	public ChooseCall()
	{
		InitializeComponent();
	}

    private void Button_Response(object sender, EventArgs e)
    {
        App.Current.MainPage.Navigation.PushAsync(new ViewGamesResponse());
    }

    private void Button_Season(object sender, EventArgs e)
    {
        App.Current.MainPage.Navigation.PushAsync(new ViewSeasons());
    }
}