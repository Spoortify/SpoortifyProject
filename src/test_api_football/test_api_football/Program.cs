using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Channels;

namespace test_api_football
{
    internal class Program
    {
        static HttpClient client = new();
        private static readonly Api_Key api_key = GetApi_Key();
        private static readonly string x_rapidapi_key = api_key.APIKeyValue;
        private static readonly string x_rapid_host = "v3.football.api-sports.io";
        //private static List<RugbyGamePrincipalInformation> rugbyGame = new();
        private static List<RugbyLeagueResponse> rugbyLeague = new();

        static Api_Key GetApi_Key()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\..\\keys.json");
            string store = File.ReadAllText(path);
            Api_Key? api_Key = JsonSerializer.Deserialize<Api_Key>(store);
            return api_Key ?? new Api_Key();
        }

        static async Task Main(string[] args)
        {
            //client.BaseAddress = new Uri("https://v1.rugby.api-sports.io/");
            client.BaseAddress = new Uri("https://v1.hockey.api-sports.io/");
    
            client.DefaultRequestHeaders.Add("x-rapidapi-key", x_rapidapi_key);
            client.DefaultRequestHeaders.Add("x-rapidapi-host", x_rapid_host);

            string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
            var response = await client.GetAsync($"/games/?date={formattedDate}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                await Console.Out.WriteLineAsync(content);
                //var leagues = JsonSerializer.Deserialize<RugbyLeague>(content);

                //rugbyGame = games.Responses;
                //foreach (var game in games.Responses)
                //{
                //    rugbyGame.Add(new()
                //    {
                //        HomeSquadImage = game.Teams.Home.Logo,
                //        HomeSquadName = game.Teams.Home.Name,
                //        HomeSquadScore = game.Score.Home,
                //        AwaySquadImage = game.Teams.Away.Logo,
                //        AwaySquadName = game.Teams.Away.Name,
                //        AwaySquadScore = game.Score.Away
                //    });
                //}
                //rugbyGame.ForEach(f => Console.WriteLine(f.AwaySquadName));

                //rugbyGame.ForEach(r => Console.WriteLine(r.Teams.Away.Name));
                //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                //Parallel.ForEach(numbers, number =>
                //{
                //    // Operazione da eseguire su ogni numero
                //    Console.WriteLine(number);
                //});
            }
            else
            {
                Console.WriteLine("Error: {0}", response.StatusCode);
            }
        }

        //League ids:
        //Serie A -> 71
        //Premier League -> 39
        //Ligue 1 -> 61
        //Bundesliga -> 78
        //La liga -> 140
        //UEFA Champions League -> 2
        //UEFA Europa League -> 3
        //Eredivise -> 88
        //UEFA Europa Conference League -> 848
        //liga portoghese -> 94
        //liga turca -> 203

        #region football
        //HttpClient client = new HttpClient();
        //client.BaseAddress = new Uri("https://v3.football.api-sports.io/");
        //client.DefaultRequestHeaders.Add("x-rapidapi-key", "7169e21806353dcad1a1592a2b7043bd");
        //client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");

        //var response = await client.GetAsync("/injuries");
        //if (response.IsSuccessStatusCode)
        //{
        //    var content = await response.Content.ReadAsStringAsync();
        //    Console.WriteLine(content);
        //}
        //else
        //{
        //    Console.WriteLine("Error: {0}", response.StatusCode);
        //}
        #endregion
    }

    public class Api_Key
    {
        [JsonPropertyName("api_key")]
        public string APIKeyValue { get; set; } = string.Empty;
    }

}