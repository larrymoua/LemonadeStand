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
        Random rnd;
        public string newForecast;
        public double temperatureOfTheDay;

        public Weather()
        {
          minTemperature = 0;
          maxTemperature = 35;
          rnd = new Random();
          NewWeather();

        }//end Constructor
        public void NewWeather()//random and creates a new forcast{rainy, sunny, cloudy} and tempature (0-35)
        {
            int randomWeatherIndex;
            temperatureOfTheDay = rnd.Next( minTemperature, maxTemperature);
            randomWeatherIndex = rnd.Next(listOfForecast.Count);
            newForecast = listOfForecast[randomWeatherIndex];
           
        }//end NewWeather
    }//end class
}//end namespace