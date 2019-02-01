using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
<<<<<<< HEAD
=======
        public List<string> daysOfBusiness = new List<string>() { };
>>>>>>> f5ae285830bcf7872300f199ca27bcadc0858d64
        public Weather weather { get; set; }
        public List<Customer> customerList { get; set; }


        public Day()
        {
            weather = new Weather();
<<<<<<< HEAD
            List<Customer> customerList = new List<Customer>();

            if (weather.newForecast == "sunny" || weather.newForecast ==  "cloudy" &&  weather.temperatureOfTheDay > 25)
            {
                Customer customerOne = new Customer();
                customerList.Add(customerOne);
                Customer customerTwo = new Customer();
                customerList.Add(customerTwo);
                Customer customerThree = new Customer();
                customerList.Add(customerThree);
                Customer customerFour = new Customer();
                customerList.Add(customerFour);
                Customer customerFive = new Customer();
                customerList.Add(customerFive);
                Customer customerSix = new Customer();
                customerList.Add(customerSix);
                Customer customerSeven = new Customer();
                customerList.Add(customerSeven);
                Customer customerEight = new Customer();
                customerList.Add(customerEight);
                Customer customerNine = new Customer();
                customerList.Add(customerNine);
                Customer customerTen = new Customer();
                customerList.Add(customerTen);

            }
            else if(weather.newForecast == "cloudy" || weather.newForecast == "sunny" && weather.temperatureOfTheDay > 15)
            {
                Customer customerOne = new Customer();
                customerList.Add(customerOne);
                Customer customerTwo = new Customer();
                customerList.Add(customerTwo);
                Customer customerThree = new Customer();
                customerList.Add(customerThree);
                Customer customerFour = new Customer();
                customerList.Add(customerFour);
                Customer customerFive = new Customer();
                customerList.Add(customerFive);
                Customer customerSix = new Customer();
                customerList.Add(customerSix);
            }
            else if (weather.newForecast == "rainy")
            {
                Customer customerOne = new Customer();
                customerList.Add(customerOne);
                Customer customerTwo = new Customer();
                customerList.Add(customerTwo);
                Customer customerThree = new Customer();
                customerList.Add(customerThree);
            }
=======
            weather.DisplayWeather();

            if (weather.newForecast == "sunny" &&  weather.temperatureOfTheDay > 25)
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
            else if (weather.newForecast == "rainy" && weather.temperatureOfTheDay > 5)
            {
                Customer customerOne = new Customer();
                Customer customerTwo = new Customer();
                Customer customerThree = new Customer();
            }
            weather.DisplayWeather();
>>>>>>> f5ae285830bcf7872300f199ca27bcadc0858d64
        }//end constructor

        public void DisplayDay()
        {
            throw new System.NotImplementedException();
        }

    }
}