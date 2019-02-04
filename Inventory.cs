using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        public double pitchersYouHave;
        public double lemonsInInventory;
        public double sugarInInventory;
        public double iceInInventory;

        public Inventory()
        {
      
        }
        public void UsePitchers(double amountofpitchers)//Userinput how many pictchers they want to make
        {
            pitchersYouHave = pitchersYouHave + amountofpitchers;
        }

        public void DisposePitches()//after day ends left overs are disposed 
        {
            pitchersYouHave = pitchersYouHave - pitchersYouHave;
        }
        public void UseLemons(double uselemons, double amountofpitchers)
        {
            lemonsInInventory = (uselemons * amountofpitchers) - lemonsInInventory;
        }
        public void UseIce(double useice, double amountofpitchers)
        {
            iceInInventory =( useice* amountofpitchers) - iceInInventory;
        }
        public void UseSugar(double usesugar, double amountofpitchers)
        {
            sugarInInventory = (usesugar * amountofpitchers )- sugarInInventory;
        }
    }//end NameSpace
}//end class