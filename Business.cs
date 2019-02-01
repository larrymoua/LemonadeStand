using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Business
    {
        private static string name;
        public Budget Budget { get; set; }
        public Inventory Inventory { get; set; }

        public string Name { get { return name; } set { name = value; } }

        public Business()
        {
            Budget = new Budget();

        }//end constructor
    }//end class
}//end namespace