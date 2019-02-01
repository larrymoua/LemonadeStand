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
           
            Console.WriteLine(@" __    _____    __    __   _____   __  __");
            Console.WriteLine(@"| |    | ___|  |  \  /  | / _ _ \ |  \ | |");
            Console.WriteLine(@"| |    | L_    |   \/   | | | | | |   \| |");
            Console.WriteLine(@"| |    | __|   |_|\   |_| | | | | |      |");
            Console.WriteLine(@"| |___ | |___  | | \_/| | | |_| | | |\   |");
            Console.WriteLine(@"L_____||_____| |_|    |_|  \____/ |_| \__|");
            Console.ReadLine();

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
            Console.WriteLine("Please set a price you want to sell each cup of lemonade for.");
            double result = Convert.ToDouble(Console.ReadLine());
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
        public static double PurchaseLemonade(Business business)
        {
            double result;

            Console.WriteLine("\nLets Head to the store...");
            Thread.Sleep(1000);
            Console.WriteLine($"Lemons cost : $ {Store.lemonsPrice} \tSugarCubes cost : $ {Store.sugarPrice} \tIce Cube : $ {Store.icePrice}");
            Console.WriteLine("\nRecipe(1 pitcher = 5 cups) = Lemons : 3  SugarCubes : 2  Ice Cubes : 5 ");

            Console.WriteLine($"\nBusiness Budget : {business.Budget.cash} $");

            Console.WriteLine("\nHow many pitchers do you want to purchase?");

       
            result = Convert.ToDouble(Console.ReadLine());
            return result;

        }
        public static void DisplayProfits(Business business, double TotalProfits)
        {
            Console.WriteLine($"\n Profit : ${TotalProfits} Business Budget : ${business.Budget.cash}");
        }
        public static void DisplayWeather(Day day)
        {
            Console.WriteLine($"\nThe forecast today is {day.weather.temperatureOfTheDay} degrees and {day.weather.newForecast}!");
        }//end DisplayWeather
    }//end class
}//end NamesSpace