using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public List<string> daysOfBusiness = new List<string>() { };
        public Weather weather { get; set; }
        public List<Customer> customerList { get; set; }


        public Day()
        {
            weather = new Weather();

            if(weather.newForecast == "sunny" &&  weather.temperatureOfTheDay > 25)
            {
                Customer customerOne = new Customer();
                Customer customerTwo = new Customer();
                Customer customerThree = new Customer();
                Customer customerFour = new Customer();
                Customer customerFive = new Customer();
                Customer customerSix = new Customer();
                Customer customerSeven = new Customer();
                Customer customerEight = new Customer();
                Customer customerNine = new Customer();
                Customer customerTen = new Customer();
            }
            else if(weather.newForecast == "cloudy" && weather.temperatureOfTheDay > 15)
            {
                Customer customerOne = new Customer();
                Customer customerTwo = new Customer();
                Customer customerThree = new Customer();
                Customer customerFour = new Customer();
                Customer customerFive = new Customer();
                Customer customerSix = new Customer();
            }
            else
            {
                Customer customerOne = new Customer();
                Customer customerTwo = new Customer();
                Customer customerThree = new Customer();
            }
        }

        public void DisplayDay()
        {
            throw new System.NotImplementedException();
        }

    }
}