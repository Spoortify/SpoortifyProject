﻿using System.Text.Json;

namespace test_api_football
{
    internal class Program
    {
        static HttpClient client = new();
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://v3.football.api-sports.io/");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "7169e21806353dcad1a1592a2b7043bd");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");

            var response = await client.GetAsync("/injuries");
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


        #region rugby
//        HttpClient client = new HttpClient();
//        client.BaseAddress = new Uri("https://v1.rugby.api-sports.io/");
//        client.DefaultRequestHeaders.Add("x-rapidapi-key", "7169e21806353dcad1a1592a2b7043bd");
//            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");

//            var response = await client.GetAsync("/games/?date=2023-11-12");
//            if (response.IsSuccessStatusCode)
//            {
//                var content = await response.Content.ReadAsStringAsync();
//        var rugby = JsonSerializer.Deserialize<Rugby>(content);

//                foreach (var game in rugby.Games)
//                {
//                    Console.WriteLine($"Date: {game.Date}, Time: {game.Time}, Country: {game.Country}, League: {game.League}");
//                    Console.WriteLine($"Home Team: {game.HomeTeam}, Away Team: {game.AwayTeam}");
//                    Console.WriteLine($"Score: {game.HomeScore} - {game.AwayScore}");
//                    Console.WriteLine();
//                }
//}
//            else
//{
//    Console.WriteLine("Error: {0}", response.StatusCode);
//}

        #endregion
    }
}