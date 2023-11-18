namespace test_api_football
{
    internal class Program
    {
        static HttpClient client = new();
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://v2.nba.api-sports.io/");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "7169e21806353dcad1a1592a2b7043bd");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");

            var response = await client.GetAsync("teams/statistics?id=1&season=2020");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("Error: {0}", response.StatusCode);
            }
        }
    }
}