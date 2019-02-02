using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LemonadeStand
{
    public class Game
    {
        public double pricePerCup;
        public Day day { get; set; }
        public Store store { get; set; }
        public Business businessOne { get; set; }
        public List<Day> days = new List<Day>();
        public List<Customer> customerList { get; set; }
        double TotalProfit;

        public Game()
        {
            businessOne = new Business();
            customerList = new List<Customer>();

        }//end constructor
        public void CreateDays()
        {
            int x = UserInterface.GetDays();

            for (int i = 0; i < x; i++)
            {
                day = new Day();
                days.Add(day);
            }

            if (day.weather.newForecast == "sunny" || day.weather.newForecast == "cloudy" && day.weather.temperatureOfTheDay > 25)
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
            else if (day.weather.newForecast == "cloudy" || day.weather.newForecast == "sunny" && day.weather.temperatureOfTheDay > 15)
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
            else if (day.weather.newForecast == "rainy")
            {
                Customer customerOne = new Customer();
                customerList.Add(customerOne);
                Customer customerTwo = new Customer();
                customerList.Add(customerTwo);
                Customer customerThree = new Customer();
                customerList.Add(customerThree);
            }




        }
        public void GetBusinessName()
        {
            businessOne.Name =  UserInterface.SetName();
        }
        public void PurchaseLemonade()
        {
          double AmountOfPitchersBuying =  UserInterface.PurchaseLemonade(businessOne);
          double CostperPitcher = (Store.icePrice * 5) + (Store.lemonsPrice * 3) + (Store.sugarPrice * 2);
          businessOne.Budget.cash = businessOne.Budget.cash - (CostperPitcher * AmountOfPitchersBuying);
          businessOne.Inventory.pitchersYouHave = AmountOfPitchersBuying;
          double cupsOfLemonadeYouHave = (businessOne.Inventory.pitchersYouHave * 5);
          Console.Clear();
          Console.WriteLine($"You have {businessOne.Inventory.pitchersYouHave} ({cupsOfLemonadeYouHave} cups) pitchers in your inventory..");
          Console.WriteLine($"Bank Account : $ {businessOne.Budget.cash} ");

        }//end PurchaseLemonade
        public void ContinueOrRetire()
        {
            throw new System.NotImplementedException();
        }
        public void ChooseBusinessSellPrice()
        {
            pricePerCup = UserInterface.ChooseSellPrice();

        }//end ChooseBusinessSellPrice
        public void SellLemonade()
        {
            int happyMoodMuiltiplier = 2;
           
            for(int i = 0; i < customerList.Count; ++i)
            {
                if (customerList[i].mood == "sad")
                {
                    return;
                }
                else if (customerList[i].mood == "happy")
                {
                    TotalProfit =+ pricePerCup * happyMoodMuiltiplier;
                }
                else if (customerList[i].mood == "normal")
                {
                    TotalProfit =+ pricePerCup;
                }

            }//end for loop
        
            businessOne.Budget.cash = TotalProfit + businessOne.Budget.cash;
        }
        public void RunGame()
        {
            UserInterface.RunUserInterface();
            GetBusinessName();
            CreateDays();

            for (int i = 0; i < days.Count; ++i)
            {
                Console.WriteLine($"\n\t\t\t\tDay : {i+1}");
                UserInterface.DisplayWeather(days[i]);
                PurchaseLemonade();
                ChooseBusinessSellPrice();
                SellLemonade();
                UserInterface.DisplayProfits(businessOne,TotalProfit);
                
            }         
        }//end RunGame
    }//end class
}//end namespace