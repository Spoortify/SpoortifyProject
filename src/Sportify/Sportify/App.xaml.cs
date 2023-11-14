using Sportify.View;

namespace Sportify
{
    public partial class App : Application
    {
        public static HttpClient ClientF1 = new HttpClient();
        public App()
        {
            InitializeComponent();
            ClientF1.BaseAddress = new Uri("https://v1.formula-1.api-sports.io");
            ClientF1.DefaultRequestHeaders.Add("x-rapidapi-key", "5a00e1120640f33486efef17ad7818e6");
            ClientF1.DefaultRequestHeaders.Add("x-rapidapi-host", "v1.formula-1.api-sports.io");
            MainPage = new AppShell();
        }
    }
}