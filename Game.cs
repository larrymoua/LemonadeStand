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
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                day = new Day(rnd);
                days.Add(day);
            }

            if (day.weather.newForecast == "sunny" || day.weather.newForecast == "cloudy" && day.weather.temperatureOfTheDay > 25)
            {
                Customer customerOne = new Customer(rnd);
                customerList.Add(customerOne);
                Customer customerTwo = new Customer(rnd);
                customerList.Add(customerTwo);
                Customer customerThree = new Customer(rnd);
                customerList.Add(customerThree);
                Customer customerFour = new Customer(rnd);
                customerList.Add(customerFour);
                Customer customerFive = new Customer(rnd);
                customerList.Add(customerFive);
                Customer customerSix = new Customer(rnd);
                customerList.Add(customerSix);
                Customer customerSeven = new Customer(rnd);
                customerList.Add(customerSeven);
                Customer customerEight = new Customer(rnd);
                customerList.Add(customerEight);
                Customer customerNine = new Customer(rnd);
                customerList.Add(customerNine);
                Customer customerTen = new Customer(rnd);
                customerList.Add(customerTen);

            }
            else if (day.weather.newForecast == "cloudy" || day.weather.newForecast == "sunny" && day.weather.temperatureOfTheDay > 15)
            {
                Customer customerOne = new Customer(rnd);
                customerList.Add(customerOne);
                Customer customerTwo = new Customer(rnd);
                customerList.Add(customerTwo);
                Customer customerThree = new Customer(rnd);
                customerList.Add(customerThree);
                Customer customerFour = new Customer(rnd);
                customerList.Add(customerFour);
                Customer customerFive = new Customer(rnd);
                customerList.Add(customerFive);
                Customer customerSix = new Customer(rnd);
                customerList.Add(customerSix);
            }
            else if (day.weather.newForecast == "rainy")
            {
                Customer customerOne = new Customer(rnd);
                customerList.Add(customerOne);
                Customer customerTwo = new Customer(rnd);
                customerList.Add(customerTwo);
                Customer customerThree = new Customer(rnd);
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
            string UserChoiceRetireOrContinue = UserInterface.OptionsToContinueOrRetire();
            if(UserChoiceRetireOrContinue == "1")
            {
                return;
            }
            else if(UserChoiceRetireOrContinue == "2")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("INVALID INPUT, TRY AGAIN!");
                ContinueOrRetire();
            }

           
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
                DiposeLeftoverLemonade(businessOne);
                if(i+1 < days.Count)
                {
                    ContinueOrRetire();
                }                             
            }         
        }//end RunGame
        public void DiposeLeftoverLemonade(Business business)
        {
            business.Inventory.DisposePitches();
        }

    }//end class
}//end namespace