﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory//one responsibility
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
        public void UseLemons(double uselemons, double amountofpitchers)//uses lemons for each pitcher and removes what you used from your inventory
        {
           
            lemonsInInventory = lemonsInInventory - (uselemons * amountofpitchers);
        }
        public void UseIce(double useice, double amountofpitchers)//uses ice for each pitcher and removes what you used from your inventory
        {
            iceInInventory = iceInInventory - ( useice* amountofpitchers) ;
        }
        public void UseSugar(double usesugar, double amountofpitchers)//uses sugar for each pitcher and removes what you used from your inventory
        {
            sugarInInventory = sugarInInventory - (usesugar * amountofpitchers );
        }
    }//end NameSpace
}//end class