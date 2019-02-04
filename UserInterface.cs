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
            Console.WriteLine("\nRun a lemonade stand for 7 days and know weather could affective your business. You will have a budget of 10 $ to purchase pitchers(5 cups) of lemonade to sell. Also you will have the option of selling cups of lemonade for your own price. Goodluck and lets come out with a profit!");
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

        public static double ChooseSellPrice()
        {
            double result = 0;

            Console.WriteLine("Please set a price you want to sell each cup of lemonade for.");
            try
            {
                result = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("INVALID INPUT, TRY AGAIN.");
                ChooseSellPrice();
            }
          
            return result;
        }
        public static int GetDays()
        {
            int result = 0;
            
            Console.WriteLine("How many days do you want to run your business?");
            try
            {
                 result = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("INVALID INPUT, TRY AGAIN.");
                GetDays();
            }
            return result; 
        }
        public static void DisplayStorePricesNBudget(Business business)
        {

            Console.WriteLine("\nLets Head to the store...");
            Thread.Sleep(1000);
            Console.WriteLine($"Lemons cost : $ {Store.lemonsPrice} \tSugarCubes cost : $ {Store.sugarPrice} \tIce Cube : $ {Store.icePrice}");
            Console.WriteLine($"\nBusiness Budget : {business.Budget.cash} $");

        }
        public static void DisplayInventory(Business business)
        {
            Console.WriteLine($"You have {business.Inventory.pitchersYouHave} pitchers in your inventory..");
            Console.WriteLine($"Lemons : {business.Inventory.lemonsInInventory} \t Sugar : {business.Inventory.sugarInInventory} \t Ice : {business.Inventory.iceInInventory}");
            Console.WriteLine($"Bank Account : $ {business.Budget.cash} ");
        }
        public static double GetDouble(string prompt)
        {
            Console.WriteLine(prompt);
            double result = Convert.ToDouble(Console.ReadLine());
            return result;
        }
        public static void DisplayProfits(Business business, double TotalProfits)
        {
            Console.WriteLine($"\n Profit : ${TotalProfits} Business Budget : ${business.Budget.cash}");
        }
        public static void DisplayWeather(Day day)
        {
            Console.WriteLine($"\nThe forecast today is {day.weather.temperatureOfTheDay} degrees and {day.weather.newForecast}!");
            Console.WriteLine("(Warning weather may effect your sells!)");
        }//end DisplayWeather
        public static string OptionsToContinueOrRetire()
        {
            string result;

            Console.WriteLine("Would you like to (1)Continue your business or (2)retire");
            result = Console.ReadLine();

            return result;
            
        }//end OptionsToContinueOrRetire
    }//end class
}//end NamesSpace