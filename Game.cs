﻿using System;
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
<<<<<<< HEAD
                day = new Day();
                days.Add(day);
            }

        }
        public void GetBusinessName()
        {
            businessOne.Name =  UserInterface.SetName();
        }
=======
                days.Add(day);
            }
        }
        public void GetBusinessName()
        {
            businessOne.Name =  UserInterface.SetName();
        }
>>>>>>> f5ae285830bcf7872300f199ca27bcadc0858d64
        public void PurchaseLemonade()
        {
          double AmountOfPitchersBuying =  UserInterface.PurchaseLemonade(businessOne);
          double CostperPitcher = (Store.icePrice * 5) + (Store.lemonsPrice * 3) + (Store.sugarPrice * 2);
          businessOne.Budget.cash = businessOne.Budget.cash - (CostperPitcher * AmountOfPitchersBuying);
<<<<<<< HEAD
          businessOne.Inventory.pitchersYouHave = AmountOfPitchersBuying;
          double cupsOfLemonadeYouHave = (businessOne.Inventory.pitchersYouHave * 5);
          Console.Clear();
          Console.WriteLine($"You have {businessOne.Inventory.pitchersYouHave} ({cupsOfLemonadeYouHave} cups) pitchers in your inventory..");
          Console.WriteLine($"Bank Account : $ {businessOne.Budget.cash} ");

=======
           
>>>>>>> f5ae285830bcf7872300f199ca27bcadc0858d64
        }//end PurchaseLemonade
        public void ContinueOrRetire()
        {
            throw new System.NotImplementedException();
        }
<<<<<<< HEAD
        public void ChooseBusinessSellPrice(Day day)
        {
            pricePerCup = UserInterface.ChooseSellPrice();
            for (int i = 0; i < day.customerList.Count; i++)
            {
                Customer customer = day.customerList[i];
=======
        public void ChooseBusinessSellPrice()
        {
            pricePerCup = UserInterface.ChooseSellPrice();
            foreach (Customer customer in day.customerList)
            {
>>>>>>> f5ae285830bcf7872300f199ca27bcadc0858d64
                businessOne.Budget.cash = pricePerCup + businessOne.Budget.cash;
            }

        }//end ChooseBusinessSellPrice
        public void RunGame()
        {
            UserInterface.RunUserInterface();
            GetBusinessName();
            CreateDays();
<<<<<<< HEAD

            for (int i = 0; i < days.Count; ++i)
            {
                UserInterface.DisplayWeather(days[i]);
                PurchaseLemonade();
                ChooseBusinessSellPrice(days[i]);
                
            }
          
=======
            PurchaseLemonade();
            ChooseBusinessSellPrice();
>>>>>>> f5ae285830bcf7872300f199ca27bcadc0858d64
        }
    }//end class
}//end namespace