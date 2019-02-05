using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        public int minTemperature;
        public int maxTemperature;
        List<string> listOfForecast = new List<string>() {"rainy" , "sunny", "cloudy" };
        public string newForecast;
        public double temperatureOfTheDay;

        public Weather(Random rnd)
        {
          minTemperature = 0;
          maxTemperature = 35;
          NewWeather(rnd);

        }//end Constructor
        public void NewWeather(Random rnd)//random and creates a new forcast{rainy, sunny, cloudy} and tempature (0-35)
        {
            int randomWeatherIndex;
            temperatureOfTheDay = rnd.Next( minTemperature, maxTemperature);
            randomWeatherIndex = rnd.Next(listOfForecast.Count);
            newForecast = listOfForecast[randomWeatherIndex];
           
        }//end NewWeather
    }//end class
}//end namespace