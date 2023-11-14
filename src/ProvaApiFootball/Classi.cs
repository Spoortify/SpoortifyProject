using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaApiFootball
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Driver
    {
        public int id { get; set; }
        public string name { get; set; }
        public string abbr { get; set; }
        public int? number { get; set; }
        public string image { get; set; }
    }

    public class Parameters
    {
        public string season { get; set; }
    }

    public class Response
    {
        public int position { get; set; }
        public Driver driver { get; set; }
        public Team team { get; set; }
        public int? points { get; set; }
        public int wins { get; set; }
        public int? behind { get; set; }
        public int season { get; set; }
    }

    public class Formula1
    {
        public string get { get; set; }
        public Parameters parameters { get; set; }
        public List<object> errors { get; set; }
        public int results { get; set; }
        public List<Response> response { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
    }


}
