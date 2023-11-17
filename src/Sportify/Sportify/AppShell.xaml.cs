using Sportify.View;

namespace Sportify
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TrackList), typeof(TrackList));
            Routing.RegisterRoute(nameof(Standings), typeof(Standings));
            Routing.RegisterRoute(nameof(ConstructorStandings), typeof(ConstructorStandings));
            Routing.RegisterRoute(nameof(TeamList), typeof(TeamList));
            Routing.RegisterRoute(nameof(CurrentSeason), typeof(CurrentSeason));
            Routing.RegisterRoute(nameof(RaceDetails), typeof(RaceDetails));
            Routing.RegisterRoute(nameof(RaceResults), typeof(RaceResults));
            Routing.RegisterRoute(nameof(HomeRugby), typeof(HomeRugby));
            Routing.RegisterRoute(nameof(HomeFormula1), typeof(HomeFormula1));
            Routing.RegisterRoute("ViewTypes", typeof(ViewTypes));
            Routing.RegisterRoute(nameof(ChooseCall), typeof(ChooseCall));
        }
    }
}