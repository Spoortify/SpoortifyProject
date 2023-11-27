using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using Sportify.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class HomeFootballController : ObservableObject
    {
        [ObservableProperty]
        List<LeagueModel> leagues = new List<LeagueModel>
        {
            new LeagueModel("Premier League", "https://upload.wikimedia.org/wikipedia/it/6/6d/Premier_League_Logo_2016.png"),
            new LeagueModel("Serie A", "https://upload.wikimedia.org/wikipedia/commons/c/c2/Serie_A.png"),
            new LeagueModel("Bundesliga", "https://upload.wikimedia.org/wikipedia/it/thumb/9/98/Logo_Bundesliga.svg/1200px-Logo_Bundesliga.svg.png"),
            new LeagueModel("Ligue 1", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Ligue1_Uber_Eats_logo.png/327px-Ligue1_Uber_Eats_logo.png"),
            new LeagueModel("Eredivisie", "https://upload.wikimedia.org/wikipedia/commons/4/46/Eredivisie_nuovo_logo.png"),
            new LeagueModel("Super Lig", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/S%C3%BCper_Lig_logo.svg/langit-640px-S%C3%BCper_Lig_logo.svg.png"),
            new LeagueModel("Primeira Liga", "https://1000logos.net/wp-content/uploads/2022/01/Portuguese-Primeira-Liga-logo-2009.png"),
            new LeagueModel("Champions League", "https://sportsmanheight.com/wp-content/uploads/2023/06/1-3.png"),
            new LeagueModel("Europa League", "https://i.imgur.com/FRrX0r1.png"),
            new LeagueModel("Conference League", "https://upload.wikimedia.org/wikipedia/en/thumb/3/30/UEFA_Europa_Conference_League.svg/1200px-UEFA_Europa_Conference_League.svg.png"),
            new LeagueModel("Euro Qualification", "https://brandlogos.net/wp-content/uploads/2023/09/european_qualifiers-logo_brandlogos.net_lsklv-512x573.png")
        };


        [RelayCommand]
        async Task GoToLeague(LeagueModel league)
        {
            var id = App.GetFootballLeagueId(league.Name);
            await Shell.Current.GoToAsync(nameof(FootballStandings), true, new Dictionary<string, object>
            {
                { "Id", id },
                {"League", league }
            });
        }
    }
}
