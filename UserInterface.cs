using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LemonadeStand
{
    static class UserInterface
    {

        public static void RunUserInterface()
        {
            Background();
            CoverScreen();
            DisplayRules();

        }
        static void Background()
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          Console.BackgroundColor = ConsoleColor.Black;
        }

        static void CoverScreen()
        {
           
            Console.WriteLine(@"  ___      ______   ____    ___   ______  ___   __      _____       ______     _________      ");
            Console.WriteLine(@" |  |     |  ___|  |   \  /   |  / _ _  \ |  \ || |    /  _  \     |   _  \   |   ______|");
            Console.WriteLine(@" || |     || L_    ||   \/    | || | |  | ||   \| |   // / \  \    || | \  \  || L___      ");
            Console.WriteLine(@" || |     || __|   || |\      | || |/|  | ||      |  // ____   \   || |  )  \ ||  ___|   ");
            Console.WriteLine(@" || |____ || |___  || | \_/|  | || |_|  | || |\   | // /    \\  \  || |_/   / || |____   ");
            Console.WriteLine(@"//_____/ //______| //_|    ||_| \_\_____/ //_|\\__|//_/      \\__\ //______/ //_______|          ");
            Thread.Sleep(1000);

        }
        static void DisplayRules()
        {
            Console.WriteLine("\n\n\t\t\t\t\tLemonade Stand Rules");
            Console.WriteLine("\nRun a lemonade stand for as many days you want and remember weather could affective your business.");
            Console.WriteLine("YOUR LEMONADE WILL NOT BE GOOD AFTER 1 DAY, IT WILL BE DISPOSED.");
            Console.WriteLine("You will have a bank account of 10 $ to purchase pitchers(5 cups) of lemonade to sell. Also you will have the");
            Console.WriteLine("option of selling cups of lemonade for your own price. Goodluck and lets come out with a profit!");
            Console.WriteLine("\n\n Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        public static string SetName()
        {
            string name = "";
            Console.WriteLine("What do you want to name your business?");
            try
            {
                name = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("INVALID INPUT! PLEASE TRY AGAIN");
                SetName();
            }
            Console.WriteLine($"Congradulations {name}, you are now open for business!");
            Console.ReadLine();
            return name;
        }//end SetName

        public static void DisplayStorePricesNBudget(Business business)
        {

            Console.WriteLine("\n\t\t\tSTORE PRICES");
            Console.WriteLine($"Lemons cost : $ {Store.lemonsPrice} \tSugarCubes cost : $ {Store.sugarPrice} \tIce Cube : $ {Store.icePrice}");
        }
        public static void DisplayInventory(Business business)
        {
            double cupsPerpitcher = 5;
           cupsPerpitcher = business.Inventory.pitchersYouHave* cupsPerpitcher;
            Console.WriteLine($"\nYou have {business.Inventory.pitchersYouHave} ({cupsPerpitcher} cups)pitchers in your inventory..");
            Console.WriteLine($"Lemons : {business.Inventory.lemonsInInventory} \t Sugar : {business.Inventory.sugarInInventory} \t Ice : {business.Inventory.iceInInventory}");
            Console.WriteLine($"Business Bank Account :  $ {business.Budget.cash} ");
        }
        public static double GetDouble(string prompt)
        {
            double result = 0;

            Console.WriteLine(prompt);
            try
            {
               result = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("INVALID INPUT, TRY AGAIN");
                return GetDouble(prompt);

            }
            
            return result;
        }
        public static void DisplayProfits(Business business, double TotalProfits, double runningTotal)
        {
            Console.WriteLine("Day rolls by....");
            Thread.Sleep(2000);
            Console.WriteLine($"\nToday's Profit : ${TotalProfits} Business Bank Account : ${business.Budget.cash}");
            Console.WriteLine($"Overall Profits (start amount $10) : ${runningTotal}");
            Console.ReadLine();
        }
        public static void DisplayWeather(Day day)
        {
            Console.WriteLine($"\nThe actual forecast today is {day.weather.temperatureOfTheDay} degrees and {day.weather.newForecast}!");
            Console.WriteLine("(Warning weather may effect your sells!)");
        }//end DisplayWeather
        public static void PredictedForecast(Day day)
        {
            Console.WriteLine($"Predicted forecast tomrrow is {day.weather.temperatureOfTheDay - 2} degrees and {day.weather.newForecast}...");
            Thread.Sleep(2000);

        }
        public static void LetsMakeLemonade()
        {
            Console.WriteLine("Lets make our lemonade, please enter quanity of each ingredient you want in each pitcher.");

        }
        public static double DisplayTasteOfLemonade(double lemons, double sugar, double ice)
        {
            double lostCustomer = 0;
            int makesSweetlemonade = 3;
            int coldLemonade = 3;
            int wateredDownLemonade = 2;
            string tasteResult = "Your lemonade is";

            if(sugar == makesSweetlemonade || sugar > makesSweetlemonade)
            {
                Console.WriteLine($"You added {sugar} sugarcubes to each pitcher of lemonade.");
                tasteResult += ",SWEEET!";
               
            }
            else 
            {
                Console.WriteLine($"You added {sugar} sugarcubes to each pitcher of lemonade.");
                tasteResult += ",sour";
                lostCustomer++;
            }
            if(ice == coldLemonade || ice > coldLemonade)
            {
                Console.WriteLine($"You added {ice} ice cubes to each pitcher of lemonade.");
                tasteResult += ",nice and cold";
            }
            else
            {
                Console.WriteLine($"You added {ice} ice cubes to each pitcher of lemonade.");
                tasteResult += ",warm";
                lostCustomer++;
            }
            if(lemons == wateredDownLemonade || lemons > wateredDownLemonade)
            {
                Console.WriteLine($"You added {lemons} lemons to each pitcher of lemonade.");
                tasteResult += ",TASTEY";
            }
            else
            {
                Console.WriteLine($"You added {lemons} lemons to each pitcher of lemonade.");
                tasteResult += ", WATERED DOWN";
                lostCustomer++;
            }
            Console.WriteLine(tasteResult);
            return lostCustomer;

        }//end Displaying Taste
        public static string GetString(string prompt)
        {
            string result = "";

            Console.WriteLine(prompt);
            try
            {
                result = Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("INVALID INPUT");
                GetString(prompt);
            }
            return result;
        }
        public static double MakeLemonade(string ingredient, Business business)
        {
            double result = 0;
            Console.WriteLine($"How much {ingredient} you want to use?");
            try
            {
               result = Convert.ToDouble(Console.ReadLine());
                if(ingredient == "lemons")
                {
                    if (result > business.Inventory.lemonsInInventory)
                    {
                        Console.WriteLine($"You do not have enough {ingredient} in your inventory!");
                        MakeLemonade(ingredient, business);
                    }
                    else if(result == business.Inventory.lemonsInInventory)
                    {
                        Console.WriteLine("You used all your lemons in your inventory!");
                    }
                }
                if (ingredient == "sugar")
                {
                    if (result > business.Inventory.sugarInInventory)
                    {
                        Console.WriteLine($"You do not have enough {ingredient} in your inventory!");
                        MakeLemonade(ingredient, business);
                    }
                    else if(result == business.Inventory.sugarInInventory)
                    {
                        Console.WriteLine("You used all your sugar in your inventory!");
                    }
                }
                if (ingredient == "ice")
                {
                    if (result > business.Inventory.iceInInventory)
                    {
                        Console.WriteLine($"You do not have enough {ingredient} in your inventory!");
                        MakeLemonade(ingredient, business);
                    }
                    else if(result == business.Inventory.iceInInventory){
                        Console.WriteLine("You used all your ice in your inventory!");
                    }
                }

            }
            catch(Exception)
            {
                Console.WriteLine("INVALID INPUT, TRY AGAIN");
                MakeLemonade(ingredient, business);
            }
            return result;
        }//end makelemonade
        public static  void EndGameText()
        {
            Console.WriteLine("Unfortunitly your time is up, thanks for playing LEMONADE STAND!");
            Console.ReadLine();
        }
    }//end class
}//end NamesSpace