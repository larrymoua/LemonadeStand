using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public List<string> daysOfBusiness = new List<string>() { };
        public Weather weather { get; set; }
  
        public Day()
        {
            weather = new Weather();

        }//end constructor

        public void DisplayDay()
        {
            throw new System.NotImplementedException();
        }

    }
}