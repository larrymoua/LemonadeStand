using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        public Game()
        {
            throw new System.NotImplementedException();
        }

        public Rules Rules
        {
            get => default(Rules);
            set
            {
            }
        }

        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }

        public int playerOne
        {
            get => default(int);
            set
            {
            }
        }
        public void MainMenu()
        {
            string chooseDifficulty;

           Console.WriteLine("1. EASY\n2. MEDIUM\n.3 HARD");
           chooseDifficulty =  Console.ReadLine();

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


        public void ChooseSellPrice()
        {
            throw new System.NotImplementedException();
        }

        public void PurchaseLemonade()
        {
            throw new System.NotImplementedException();
        }

        public void ContinueOrRetire()
        {
            throw new System.NotImplementedException();
        }

        public void RunGame()
        {
            throw new System.NotImplementedException();
        }
    }//end class
}//end namespace