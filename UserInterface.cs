﻿using System;
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
            
        }
        static void DisplayRules()
        {
            Console.WriteLine("\t\t\t\t\tLemonade Stand Rules");
            Console.WriteLine("\n\n\tRun a lemonade stand for 7 days and know weather could affective your business. You will have a budget of 10$ to purchase pitchers(5 cups) of lemonade to sell. Also you will have the option of selling cups of lemonade for your own price. Goodluck and lets come out with a profit!");
            Console.ReadLine();
        }
        public static string SetName()
        {
            string name;
            Console.WriteLine("What do you want to name your business?");
            name  = Console.ReadLine();
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
            Console.WriteLine("How many days do you want to run your business?");
            int result = Convert.ToInt16(Console.ReadLine());
            return result; 
        }
        public static double PurchaseLemonade(Business business)
        {
            string yN;
            double result;
            Console.WriteLine("Lets Head to the store...");
            Thread.Sleep(2000);
            Console.WriteLine($"Lemons cost : {Store.lemonsPrice} \tSugarCubes cost : {Store.sugarPrice} \tIce Cube : {Store.icePrice}");
            Console.WriteLine("\nRecipe( 1 pitcher) = Lemons : 3  SugarCubes : 2  Ice Cubes : 5 ");

            Console.WriteLine($"\nBank Account : {business.Budget.cash}$");

            Console.WriteLine("\n\nDid you want make a purchase? y/n");
            yN = Console.ReadLine().ToLower();
            if (yN == "y")
            {
                Console.WriteLine("\nHow many pitches do you want to purchase?");
              
            }
            else if ( yN == "n")
            {

            }
            result = Convert.ToDouble(Console.ReadLine());
            return result;

        }
        static void MainMenu()
        {
            string chooseDifficulty;

            Console.WriteLine("1. EASY\n2. MEDIUM\n3. HARD");
            chooseDifficulty = Console.ReadLine();

            switch (chooseDifficulty)
            {
                case "1":
               
                    break;
                case "2":

                    break;
                case "3":

                    break;
                default:
                    MainMenu();
                    break;
            }//end switchcase
        }//end MainMenu
    }//end class
}//end NamesSpace