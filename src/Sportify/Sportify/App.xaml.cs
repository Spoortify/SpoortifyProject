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
            nbaClient.DefaultRequestHeaders.Add("x-rapidapi-key", "4eb54507877398a66e1f0828f61ae689");
            nbaClient.DefaultRequestHeaders.Add("x-rapidapi-host", "api-nba-v1.p.rapidapi.com");
            MainPage = new AppShell();
        }
    }
}