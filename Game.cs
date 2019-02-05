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
        Random rnd;

        public Game()
        {
            businessOne = new Business();
            customerList = new List<Customer>();
            rnd = new Random();

        }//end constructor
        public void CreateDays()
        {
            
            double amountOfDaysRunBusiness = UserInterface.GetDouble("How many days do you want to run your business ? ");
            if(amountOfDaysRunBusiness  < 1)
            {
                Console.WriteLine("CAN NOT BE 0 OR LESS DAYS!");
                CreateDays();
            }
            for (int i = 0; i < amountOfDaysRunBusiness; i++)
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
                Customer customerEleven = new Customer(rnd);
                customerList.Add(customerEleven);
                Customer customerTweleve = new Customer(rnd);
                customerList.Add(customerTweleve);
                Customer customerThirdteen = new Customer(rnd);
                customerList.Add(customerThirdteen);
                Customer customerFourteen = new Customer(rnd);
                customerList.Add(customerFourteen);
                Customer customerFifthTeen = new Customer(rnd);
                customerList.Add(customerFifthTeen);
                Customer customerSixteen = new Customer(rnd);
                customerList.Add(customerSixteen);

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
                Customer customerSeven = new Customer(rnd);
                customerList.Add(customerSeven);
                Customer customerEight = new Customer(rnd);
                customerList.Add(customerEight);
                Customer customerNine = new Customer(rnd);
                customerList.Add(customerNine);
                Customer customerTen = new Customer(rnd);
                customerList.Add(customerTen);
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

           double TotalCostOfIngredients = totalPriceOfIceBought + totalPriceOfLemonsBought + totalPriceOfSugarBought;

            if (TotalCostOfIngredients < business.Budget.cash || TotalCostOfIngredients == business.Budget.cash)
            {
                business.Budget.cash -= totalPriceOfIceBought + totalPriceOfLemonsBought + totalPriceOfSugarBought;
                business.Inventory.iceInInventory = userBuyIceQuanity + business.Inventory.iceInInventory;
                business.Inventory.lemonsInInventory = userBuyLemonsQuanity + business.Inventory.lemonsInInventory;
                business.Inventory.sugarInInventory = userBuySugarQuanity + business.Inventory.sugarInInventory;

            }
            else
            {
                Console.WriteLine("\nYou dont have enough money to buy all this stuff!");
                PurchaesIngredients(business);
            }

        }//end PurchaesIngredients
        public void ContinueOrRetire()
        {
            double UserChoiceRetireOrContinue = UserInterface.GetDouble("Would you like to(1)Continue your business or(2)retire");
            if(UserChoiceRetireOrContinue == 1)
            {
                Console.Clear();
            }
            else if(UserChoiceRetireOrContinue == 2)
            {
                Console.WriteLine("Retiring already? Shanks for playing LEMONADE STAND!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("INVALID INPUT, TRY AGAIN!");
                ContinueOrRetire();
            }          
        }//ContinueOrRetire
        public void SellLemonade()
        {
            pricePerCup = UserInterface.GetDouble("Please set a price you want to sell each cup of lemonade for.");

            if(pricePerCup > 5)
            {
                customerList.RemoveRange(0,15);
                Console.WriteLine("That seems to expensive, you probably will not get any customers today!");
            }
            else if ( pricePerCup < 1 || pricePerCup == 1)
            {
                Customer bonusCustomerGoodPrice = new Customer(rnd);
                customerList.Add(bonusCustomerGoodPrice);
                Customer bonusCustomerGoodPriceTwo = new Customer(rnd);
                customerList.Add(bonusCustomerGoodPriceTwo);
                Console.WriteLine("Great price , you should get more customers!");
            }
            else if(pricePerCup > 1 && pricePerCup < 5)
            {
                Console.WriteLine("Thats a fair price!");
            }
            int happyMoodMuiltiplier = 2;
       
           
            for(int i = 0; i < customerList.Count; i++)
            {
                if (customerList[i].mood == "sad")
                {
                    
                }
                else if (customerList[i].mood == "happy")
                {
                    TotalProfit += pricePerCup * happyMoodMuiltiplier;
                    businessOne.Budget.cash += pricePerCup * happyMoodMuiltiplier;
                }
                else if (customerList[i].mood == "normal")
                {
                    TotalProfit += pricePerCup;
                    businessOne.Budget.cash += pricePerCup;
                }
               
            }//end for loop

        }
        public void ChooseToMakeLemonade()
        {
           string userInput = UserInterface.MakeLemonadeOrNot();

            if (userInput == "y")
            {
                MakeLemonaade(businessOne);
            }
            else if ( userInput == "n")
            {

            }
            else
            {
                Console.WriteLine("INVALID INPUT!");
                ChooseToMakeLemonade();
            }
        }
        public void MakeLemonaade(Business business)
        {
            UserInterface.LetsMakeLemonade();

           
            double lemonsPerPitcher = UserInterface.MakeLemonade("lemons", business);       
            double sugarPerPitcher = UserInterface.MakeLemonade("sugar", business);
            double icePerPitcher = UserInterface.MakeLemonade("ice", business);
            double amountOfPitchers = UserInterface.GetDouble("Enter amount of pitchers you want to make : ");

            if (amountOfPitchers*lemonsPerPitcher > business.Inventory.lemonsInInventory || lemonsPerPitcher > business.Inventory.lemonsInInventory)
            {
                Console.WriteLine("You do not have enough lemons to make that many pitchers!");
                Console.WriteLine("Lets try again!");
                lemonsPerPitcher = 0;
                MakeLemonaade(business);
            }
            if(amountOfPitchers*sugarPerPitcher > business.Inventory.sugarInInventory || sugarPerPitcher > business.Inventory.sugarInInventory)
            {
                Console.WriteLine("You do not have enough sugar to make that many pitchers!");
                Console.WriteLine("Lets try again!");
                sugarPerPitcher = 0;
                MakeLemonaade(business);
            }
            if(amountOfPitchers * icePerPitcher > business.Inventory.iceInInventory || icePerPitcher > business.Inventory.iceInInventory)
            {
                Console.WriteLine("You do not have enough ice to make that many pitchers!");
                Console.WriteLine("Lets try again!");
                icePerPitcher = 0;
                MakeLemonaade(business);
            }
            business.Inventory.UsePitchers(amountOfPitchers);
            business.Inventory.UseLemons(lemonsPerPitcher, amountOfPitchers);
            business.Inventory.UseSugar(sugarPerPitcher, amountOfPitchers);
            business.Inventory.UseIce(icePerPitcher, amountOfPitchers);

            if (amountOfPitchers > 0 && (icePerPitcher > 1 || lemonsPerPitcher > 1 || sugarPerPitcher > 1))
            {
                LostCustomerBecauseOfQuality(lemonsPerPitcher, sugarPerPitcher, icePerPitcher);
                SellLemonade();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("YOU CANT MAKE ANY LEMONADE WITHOUT ANY INGREDIENTS!");
                Console.ReadLine();
                ChooseToMakeLemonade();
            }
            
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
                UserInterface.DisplayInventory(businessOne);
                PurchaesIngredients(businessOne);
                Console.Clear();
                UserInterface.DisplayInventory(businessOne);
                ChooseToMakeLemonade();
                UserInterface.DisplayProfits(businessOne,TotalProfit);
                DiposeLeftoverLemonade(businessOne);
                if(businessOne.Budget.cash == 0 && businessOne.Inventory.iceInInventory < 1 && businessOne.Inventory.lemonsInInventory < 1 && businessOne.Inventory.sugarInInventory < 1)
                {
                    Console.WriteLine("LOOKS LIKE YOU RAN OUT OF INVENTORY AND MONEY. THANKS FOR PLAYING LEMONADE STAND!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    ContinueOrRetire();
                }                     
            }
            UserInterface.EndGameText();
        }//end RunGame
        public void LostCustomerBecauseOfQuality(double lemons, double sugar, double ice)
        {
            double lostCustomer = UserInterface.DisplayTasteOfLemonade(lemons, ice, sugar);

            for(int i = 0; i < lostCustomer; i++)
            {
                customerList.RemoveAt(0);
            }
           
        }//end LostCustomerBecauseOfQuality
        public void DiposeLeftoverLemonade(Business business)
        {
            business.Inventory.DisposePitches();
        }

    }//end class
}//end namespace