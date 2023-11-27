using CommunityToolkit.Mvvm.ComponentModel;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    [QueryProperty(nameof(TrackList), "TrackList")]
    public partial class TrackListController : ObservableObject
    {
        [ObservableProperty]
        Tracks trackList;
    }
}
