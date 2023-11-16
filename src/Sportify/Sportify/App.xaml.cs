using Sportify.Model;
using Sportify.View;
using System.Text.Json;

namespace Sportify
{
    public partial class App : Application
    {
        public static HttpClient hockeyClient = new();
        private static readonly Api_Key api_key = GetApi_Key();
        private static readonly string x_rapidapi_key = api_key.APIKeyValue;
        private static readonly string x_rapid_host = "v1.hockey.api-sports.io";
        public App()
        {
            InitializeComponent();
            MainPage = new HomeHockeyGame();
            hockeyClient.BaseAddress = new Uri("https://v1.hockey.api-sports.io/");
            hockeyClient.DefaultRequestHeaders.Add("x-rapidapi-key", x_rapidapi_key);
            hockeyClient.DefaultRequestHeaders.Add("x-rapidapi-host", x_rapid_host);
        }

        private static Api_Key GetApi_Key()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\..\\..\\..\\keys.json");
            string store = File.ReadAllText(path);
            Api_Key? api_Key = JsonSerializer.Deserialize<Api_Key>(store);
            return api_Key ?? new Api_Key();
        }
    }
}