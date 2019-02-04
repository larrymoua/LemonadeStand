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
        public void UsePitchers(double usepitcher)//Userinput how many pictchers they want to make
        {
            pitchersYouHave = pitchersYouHave + useAPitcher;
        }

        public void DisposePitches()//after day ends left overs are disposed 
        {
            pitchersYouHave = pitchersYouHave - pitchersYouHave;
        }
        public void UseLemons(double uselemons)
        {
            lemonsInInventory = uselemons - lemonsInInventory;
        }
        public void UseIce(double useice)
        {

        }
        public void UseSugar(double usesugar)
        {

        }
    }//end NameSpace
}//end class