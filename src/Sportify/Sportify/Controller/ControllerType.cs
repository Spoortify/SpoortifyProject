using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Sportify.Model;

namespace Sportify.Controller
{
    [QueryProperty(nameof(Game), "Game")]
    public partial class ControllerType : ObservableObject
    {
        [ObservableProperty]
        BaseballGameResponse game;

        public ControllerType()
        {
            
        }
    }
}