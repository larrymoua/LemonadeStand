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
        public void PurchaesIngredients(Business business)
        {
           double userBuyLemonsQuanity = UserInterface.GetDouble("How many lemons you want to purchase?");
           double userBuySugarQuanity = UserInterface.GetDouble("How much sugar did you want to purchase?");
           double userBuyIceQuanity = UserInterface.GetDouble("How much ice did you want to purchase");

           double totalPriceOfLemonsBought = userBuyLemonsQuanity * Store.lemonsPrice;
           double totalPriceOfSugarBought = userBuySugarQuanity * Store.sugarPrice;
           double totalPriceOfIceBought = userBuyIceQuanity * Store.icePrice;

           business.Budget.cash -= totalPriceOfIceBought + totalPriceOfLemonsBought + totalPriceOfSugarBought;

           business.Inventory.iceInInventory = userBuyIceQuanity + business.Inventory.iceInInventory;
           business.Inventory.lemonsInInventory = userBuyLemonsQuanity + business.Inventory.lemonsInInventory;
           business.Inventory.sugarInInventory = userBuySugarQuanity + business.Inventory.sugarInInventory;


        }//end PurchaesIngredients
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
        public void MakeLemonaade(Business business)
        {
            double amountOfPitchers = UserInterface.GetDouble("Enter amount of pitchers: ");
            double lemonsPerPitcher = UserInterface.GetDouble("Enter amount of lemons: ");
            double icePerPitcher = UserInterface.GetDouble("Enter amount of ice: ");
            double sugarPerPitcher = UserInterface.GetDouble("Enter amount of sugar: ");

            business.Inventory.UsePitchers(amountOfPitchers);
            business.Inventory.UseLemons(lemonsPerPitcher, amountOfPitchers);
            business.Inventory.UseSugar(sugarPerPitcher, amountOfPitchers);
            business.Inventory.UseIce(icePerPitcher, amountOfPitchers);

        }//end makelemonade
        public void RunGame()
        {
            UserInterface.RunUserInterface();
            GetBusinessName();
            CreateDays();

            for (int i = 0; i < days.Count; ++i)
            {
                Console.WriteLine($"\n\t\t\t\tDay : {i+1}");
                UserInterface.DisplayWeather(days[i]);
                UserInterface.DisplayStorePricesNBudget(businessOne);
                PurchaesIngredients(businessOne);
                UserInterface.DisplayInventory(businessOne);
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