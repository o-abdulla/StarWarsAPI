using Microsoft.AspNetCore.DataProtection;
using Newtonsoft.Json;
using System.Net;

namespace StarWars_Api.Models
{
    public class StarwarsDAL
    {
        public static StarwarsModel GetStarwars(string character) //Adjust here
        {
            //Adjust
            //Setup
            string url = $"https://swapi.dev/api/people/?search={character}"; 

            //Request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Convert to c#
            StarwarsModel result = JsonConvert.DeserializeObject<StarwarsModel>(JSON);
            return result;
        }
    }
}
