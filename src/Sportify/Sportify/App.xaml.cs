using Sportify.View;

namespace Sportify
{
    public partial class App : Application
    {
        public static HttpClient nbaClient = new();
        public App()
        {
            InitializeComponent();
            nbaClient.BaseAddress = new Uri("https://v2.nba.api-sports.io");
            nbaClient.DefaultRequestHeaders.Add("x-rapidapi-key", "50033e93a2d49d985f3daa64adae1a80");
            nbaClient.DefaultRequestHeaders.Add("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            MainPage = new AppShell();
        }
    }
}