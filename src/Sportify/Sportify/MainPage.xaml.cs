using Sportify.Controller;
using Sportify.Model;

namespace Sportify
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var controller = new BaseballController();
            BindingContext = controller;
            controller.Start();
        }
    }
}