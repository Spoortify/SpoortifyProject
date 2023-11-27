using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    [QueryProperty(nameof(RaceDetails), "Race")]
    public partial class RaceDetailsController : ObservableObject
    {
        [ObservableProperty]
        Details raceDetails;
    }
}
