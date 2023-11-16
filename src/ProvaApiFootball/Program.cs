using RestSharp;
using System.Net.Http.Json;

namespace ProvaApiFootball
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://v1.baseball.api-sports.io");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "50033e93a2d49d985f3daa64adae1a80");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v3.football.api-sports.io");
            var response = await client.GetAsync("/leagues?season=2008");
            var stringa = await response.Content.ReadAsStringAsync();
            Console.WriteLine(stringa);
        }
    }
}