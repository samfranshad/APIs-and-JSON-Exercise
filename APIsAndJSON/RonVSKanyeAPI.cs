using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {

        public void RonVSKanye()
        {
            var client = new HttpClient();

            string kanyeURL = "https://api.kanye.rest/";
            string swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            for (int i = 1; i < 6; i++)
            {
                string kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                string swansonResponse = client.GetStringAsync(swansonURL).Result;

                string kanyeQuote = JObject.Parse(kanyeResponse)["quote"].ToString();
                string swansonQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

                Console.WriteLine($"Kanye: \"{kanyeQuote}\"");
                Console.WriteLine($"Ron: {swansonQuote}");
            }

        }

    }

       

}

