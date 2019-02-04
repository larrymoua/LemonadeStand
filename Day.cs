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
  
        public Day(Random rnd)
        {
            weather = new Weather(rnd);

        }//end constructor

    }//end class
}//end namespace