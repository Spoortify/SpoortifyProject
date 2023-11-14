﻿using Sportify.View;

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
        }
    }
}