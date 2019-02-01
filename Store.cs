using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {
        public static double lemonsPrice;
        public static double sugarPrice;
        public static double icePrice;

        static Store()
        {
            lemonsPrice = .50;
            icePrice = .10;
            sugarPrice = .10;

        }//end constructor
    }//end class
}//end namespace