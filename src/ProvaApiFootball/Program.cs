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
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "7169e21806353dcad1a1592a2b7043bd");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");
            var response = await client.GetAsync("/fixtures?league=135&season=2023");
            var lista = await response.Content.ReadFromJsonAsync<Root>();
            //var lista = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(lista);
            foreach (var item in lista.Response)
            {
                Console.WriteLine(item.Teams.Home.Name + "" + item.Teams.Away.Name + "" + item.Goals.Home + "-" + item.Goals.Away);
            }
        }
    }
}