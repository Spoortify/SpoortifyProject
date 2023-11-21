using CommunityToolkit.Mvvm.Input;

namespace Sportify.View;

public partial class HomeFootball : ContentPage
{
	public HomeFootball()
	{
		InitializeComponent();
	}

    private async void GoToTeamList(object sender, EventArgs e)
    {
        await App.Current.MainPage.Navigation.PushAsync(new FootballTeamList());
    }

    private async void GoToTodayGames(object sender, EventArgs e)
    {
        await App.Current.MainPage.Navigation.PushAsync(new FootballTodayGame());
    }

    private async void GoToFootballStandings(object sender, EventArgs e)
    {
        await App.Current.MainPage.Navigation.PushAsync(new FootballStandings());
    }
}