using CommunityToolkit.Mvvm.ComponentModel;
using Sportify.Model;

namespace Sportify.Controller
{
    public partial class SeasonTeamDetailsController : ObservableObject
    {
        [ObservableProperty]
        FootballStandingsModel team;
        public SeasonTeamDetailsController(FootballStandingsModel team)
        {
            this.team = team;
        }
    }
}
