using CommunityToolkit.Mvvm.ComponentModel;
using Sportify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Controller
{
    public partial class FootballTopScorerDetailsController : ObservableObject
    {
        [ObservableProperty]
        public FootballTopScorersResponse topScorer;
        public FootballTopScorerDetailsController(FootballTopScorersResponse topScorer)
        {
            this.topScorer = topScorer;
        }
    }
}
