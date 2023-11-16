using CommunityToolkit.Mvvm.ComponentModel;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class RugbyLeagueStandingsController : ObservableObject
    {
        [ObservableProperty]
        private List<RugbyLeagueStandingsResponse> rugbyLeagueStandings = new();
        public RugbyLeagueStandingsController(RugbyLeagueStandingsModel rugbyLeagueStandings)
        {
            this.rugbyLeagueStandings = rugbyLeagueStandings.Response[0];
        }
    }
}
