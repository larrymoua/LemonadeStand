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

        int useAPitcher;

        public Inventory()
        {
            useAPitcher = 1;
        }
        public void UsePitches()//If 5 cups of lemonade sells, use a pitcher(5 cups in a pitcher)
        {
            pitchersYouHave = pitchersYouHave - useAPitcher;
        }

        public void DisposePitches()//after day ends left overs are disposed 
        {
            pitchersYouHave = pitchersYouHave - pitchersYouHave;
        }
    }//end NameSpace
}//end class