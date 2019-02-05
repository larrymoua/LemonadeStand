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
          Console.ForegroundColor = ConsoleColor.Yellow;

        }

        static void CoverScreen()
        {
           
            Console.WriteLine(@" __       _____    ___    __    _____   __   __");
            Console.WriteLine(@"|  |     |  ___|  |   \  /  |  / _ _ \ |  \ || |");
            Console.WriteLine(@"|| |     || L_    ||   \/   | || | | | ||   \| |");
            Console.WriteLine(@"|| |     || __|   || |\     | || |/| | ||      |");
            Console.WriteLine(@"|| |____ || |___  || | \_/| | || |_| | || |\   |");
            Console.WriteLine(@"L L_____|||_____| ||_|   ||_| \_\____/ ||_|\\__|");
            Thread.Sleep(1000);

        }
        static void DisplayRules()
        {
            Console.WriteLine("\t\t\t\t\tLemonade Stand Rules");
            Console.WriteLine("\nRun a lemonade stand for as many days you want and remember weather could affective your business.");
            Console.WriteLine("You will have a budget of 10 $ to purchase pitchers(5 cups) of lemonade to sell. Also you will have the");
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
            Console.WriteLine($"You have {business.Inventory.pitchersYouHave} pitchers in your inventory..");
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
        public static void DisplayProfits(Business business, double TotalProfits)
        {
            Console.WriteLine($"\n Profit : ${TotalProfits} Business Bank Account : ${business.Budget.cash}");
            Console.ReadLine();
        }
        public static void DisplayWeather(Day day)
        {
            Console.WriteLine($"\nThe forecast today is {day.weather.temperatureOfTheDay} degrees and {day.weather.newForecast}!");
            Console.WriteLine("(Warning weather may effect your sells!)");
        }//end DisplayWeather
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
            Console.Clear();
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
            if(ice == coldLemonade)
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
        public static string MakeLemonadeOrNot()
        {
            string result = "";

            Console.WriteLine("Did you want to make lemonade today? y/n");
            try
            {
                result = Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("INVALID INPUT");
                MakeLemonadeOrNot();
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