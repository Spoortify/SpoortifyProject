using Sportify.Model;
using System.Text.Json;

namespace Sportify
{
    public partial class App : Application
    {
        public static HttpClient rugbyClient = new();
        private static readonly Api_Key api_key = GetApi_Key();
        private static readonly string x_rapidapi_key = api_key.APIKeyValue;
        private static readonly string x_rapid_host = "v3.football.api-sports.io";
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            rugbyClient.BaseAddress = new Uri("https://v1.rugby.api-sports.io/");
            rugbyClient.DefaultRequestHeaders.Add("x-rapidapi-key", x_rapidapi_key);
            rugbyClient.DefaultRequestHeaders.Add("x-rapidapi-host", x_rapid_host);
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