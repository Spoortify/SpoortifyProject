using System.Text.Json;

namespace test_api_football
{
    internal class Program
    {
        //public string LinkQuery()
        //{
        //    return $"/gamse?date={date}";
        //}

        public async Task GetBaseballApi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://v1.hockey.api-sports.io/");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "5a00e1120640f33486efef17ad7818e6");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "v1.hockey.api-sports.io/");
            var response = await client.GetAsync("games/?leage=108&season=2018");
            Console.WriteLine(response);
        }
    }
}




//7169e21806353dcad1a1592a2b7043bd
//games/?date=2023-11-15
//https://v1.hockey.api-sports.io/