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
            nbaClient.DefaultRequestHeaders.Add("x-rapidapi-key", "7169e21806353dcad1a1592a2b7043bd");
            nbaClient.DefaultRequestHeaders.Add("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            MainPage = new AppShell();
        }
    }
}