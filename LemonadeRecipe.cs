using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadeRecipe
    {
        public int[,] AllRecipes;
        public LemonadeRecipe()
        {
            AllRecipes = new int[2,3] { { 2, 4, 3 }, { 2, 1, 3 } };
        }
        public void SweetRecipe()
        {

        }
    }//end class
}//end namespace
