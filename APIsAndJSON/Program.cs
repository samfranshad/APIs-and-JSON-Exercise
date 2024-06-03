using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ronVSKanye = new RonVSKanyeAPI();
            ronVSKanye.RonVSKanye();

            Console.WriteLine();

            var openWeather = new OpenWeatherMapAPI();
            openWeather.OpenWeather();

        }
    }
}
