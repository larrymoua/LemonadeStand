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

        public Customer(Random rnd)
        {
            ChanceOfBuying = new List<string>() {"sad", "happy", "normal" };
            RandomMood(rnd);
        }
        public void RandomMood(Random rnd)//random a mood for the customer
        {
            int randomIdex;

            randomIdex = rnd.Next(ChanceOfBuying.Count);
            mood = ChanceOfBuying[randomIdex];

        }//RandomMood
    }//end class
}//end namespace