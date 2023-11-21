using Microsoft.Maui.Controls;
using Sportify.Controller;
using Sportify.Model;


namespace Sportify.View;

public partial class HockeyDetailsGame : ContentPage
{
    public HockeyDetailsGame(HockeyGameResponse hockeyGame)
    {
        InitializeComponent();
        HockeyDetailsGameController controller = new HockeyDetailsGameController(hockeyGame);
        BindingContext = controller;

        //BindingContext = new HockeyDetailsGameController();
    }
}