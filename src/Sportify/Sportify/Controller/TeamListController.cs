using CommunityToolkit.Mvvm.ComponentModel;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    [QueryProperty(nameof(TeamList),"TeamList")]
    public partial class TeamListController : ObservableObject
    {
        [ObservableProperty]
        Formula1Teams teamList;
    }
}
