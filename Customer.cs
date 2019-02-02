using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        List<string> ChanceOfBuying;
        public string mood;
        Random rnd;

        public Customer()
        {
            ChanceOfBuying = new List<string>() {"sad", "happy", "normal" };
            rnd = new Random();
            RandomMood();
        }
        public void RandomMood()
        {
            int randomIdex;

            randomIdex = rnd.Next(ChanceOfBuying.Count);
            mood = ChanceOfBuying[randomIdex];

        }//RandomMood
    }//end class
}//end namespace