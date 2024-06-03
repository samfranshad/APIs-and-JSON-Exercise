using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public void OpenWeather()
        {
            var client = new HttpClient();

            var appsettingsText = File.ReadAllText("appsettings.json");

            var apiKey = JObject.Parse(appsettingsText)["apiKey"].ToString();

            Console.WriteLine("Please enter your zip code:");
            int userZip;

            while(!int.TryParse(Console.ReadLine(), out userZip))
            {
                Console.WriteLine("Invalid input.Please enter a valid zip code.");
            }

            var url = $"https://api.openweathermap.org/data/2.5/weather?zip={userZip}&appid={apiKey}&units=imperial";

            var urlResponse = client.GetStringAsync(url).Result;

            var weatherResponse = JObject.Parse(urlResponse)["main"]["temp"].ToString();

            Console.WriteLine($"The current temperature for zip code 48328 is {weatherResponse} degrees Fahrenheit.");
        }

    }
}
