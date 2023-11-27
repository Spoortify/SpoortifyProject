using Microsoft.Maui.Controls;
using Sportify.Controller;

namespace Sportify.View;

public partial class HomeRugby : ContentPage
{
    private HomeRugbyController controller;
    public HomeRugby()
    {
        InitializeComponent();
        controller = new HomeRugbyController();
        BindingContext = controller; 
    }

    private async void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        await controller.ShowGames();
    }

}