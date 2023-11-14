using RestSharp;
using System.Net.Http.Json;

namespace ProvaApiFootball
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://v1.formula-1.api-sports.io");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "5a00e1120640f33486efef17ad7818e6");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v1.formula-1.api-sports.io");
            var response = await client.GetAsync("/rankings/drivers?season=2012");
            Formula1 lista = await response.Content.ReadFromJsonAsync<Formula1>();
            lista.response.ForEach(r => Console.WriteLine($"{r.driver.name} {r.points}"));
        }
    }
}