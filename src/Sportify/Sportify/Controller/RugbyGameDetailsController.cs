using CommunityToolkit.Mvvm.ComponentModel;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class RugbyGameDetailsController : ObservableObject
    {
        [ObservableProperty]
        public RugbyGameResponse rugbyGame;
        public RugbyGameDetailsController(RugbyGameResponse rugbyGame)
        {
            this.rugbyGame = rugbyGame;
        }
    }
}
