using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LemonadeStand
{
    public class Game
    {
        public double pricePerCup;
        public Day day { get; set; }
        public Store store { get; set; }
        public Business businessOne { get; set; }
        public List<Day> days = new List<Day>();

        public Game()
        {
            businessOne = new Business();

        }//end constructor
        public void CreateDays()
        {
            int x = UserInterface.GetDays();

            for (int i = 0; i < x; i++)
            {
                days.Add(day);
            }
        }
        public void GetBusinessName()
        {
            businessOne.Name =  UserInterface.SetName();
        }
        public void PurchaseLemonade(Business businessOne)
        {
          double AmountOfPitchersBuying =  UserInterface.PurchaseLemonade(businessOne);
          double CostperPitcher = (Store.icePrice * 5) + (Store.lemonsPrice * 3) + (Store.sugarPrice * 2);
          businessOne.Budget.cash = businessOne.Budget.cash - (CostperPitcher * AmountOfPitchersBuying);
           
        }//end PurchaseLemonade
        public void ContinueOrRetire()
        {
            throw new System.NotImplementedException();
        }
        public void ChooseBusinessSellPrice(Business businessOne)
        {
            pricePerCup = UserInterface.ChooseSellPrice();
            foreach (Customer customer in day.customerList)
            {
                businessOne.Budget.cash = pricePerCup + businessOne.Budget.cash;
            }

        }
        public void RunGame()
        {
            UserInterface.RunUserInterface();
            GetBusinessName();
            CreateDays();
        }
    }//end class
}//end namespace