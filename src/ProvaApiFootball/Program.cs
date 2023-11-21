using RestSharp;
using System.Net.Http.Json;

namespace ProvaApiFootball
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://v3.football.api-sports.io");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "5a00e1120640f33486efef17ad7818e6");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");
            var response = await client.GetAsync("/teams?league=135&season=2023");
            var lista = await response.Content.ReadAsStringAsync();
            Console.WriteLine(lista);
            //Formula1 lista = await response.Content.ReadFromJsonAsync<Formula1>();
            //lista.response.ForEach(r => Console.WriteLine($"{r.driver.name} {r.points}"));
        }
    }
}