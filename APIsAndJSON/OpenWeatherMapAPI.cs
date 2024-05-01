using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {

        public static void WeatherForCity()
        {

            HttpClient client = new HttpClient();

            Console.WriteLine("What city's weather would you like to check?");

            string cityName = Console.ReadLine();

            string APIKey = "6a2c9f40a97f9ec06fefddac00ce3d54";

            var endpointUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={APIKey}&units=imperial";

            var getWeather = client.GetStringAsync(endpointUrl).Result;

            JObject weatherObject = JObject.Parse(getWeather);

            Console.WriteLine($"The weather there in {cityName} is");

            Console.WriteLine(weatherObject["main"]["temp"]);

        

        }

       

    }
    
}
