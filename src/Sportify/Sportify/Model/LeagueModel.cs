using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.Model
{
    public class LeagueModel
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public LeagueModel(string Name, string Logo)
        {
            this.Name = Name;
            this.Logo = Logo;
        }
    }
}
