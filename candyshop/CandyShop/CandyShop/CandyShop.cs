using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopApp
{
    public class CandyShop
    {
        Sweets sweets = new Sweets();
        Lollypop lollypopClass = new Lollypop();
        Candies candyClass = new Candies();

        private double sugarStore;
        private double income = 0;
        private List<Sweets> listOfCandies = new List<Sweets>();
        private List<Sweets> listOfLollypops = new List<Sweets>();

        public CandyShop(double sugarStore)
        {
            this.sugarStore = sugarStore;
        }

        public List<Sweets> CreateCandies()
        {
            listOfCandies.Add(candyClass);
            sugarStore -= candyClass.Sugar;
            return listOfCandies;
        }

        public List<Sweets> CreateLollypops()
        {
            listOfLollypops.Add(lollypopClass);
            sugarStore -= lollypopClass.Sugar;
            return listOfLollypops;
        }

        public void RaisePrices(double percentageToRaiseTo)
        {
            candyClass.Price *= percentageToRaiseTo;
            lollypopClass.Price *= percentageToRaiseTo;
            Console.WriteLine("Raised prices to : {0}$ for candy and {1}$ for lollypop", candyClass.Price, lollypopClass.Price);
        }

        public void SellSweets(string typeToSell, int amountToSell)
        {
            if (typeToSell == "candy")
            {
                for (int i = 0; i < amountToSell; i++)
                {
                    listOfCandies.RemoveAt(0);
                    income += candyClass.Price;
                }
            }
            if (typeToSell == "lollypop")
            {
                for (int i = 0; i < amountToSell; i++)
                {
                    listOfLollypops.RemoveAt(0);
                    income += lollypopClass.Price;
                }
            }
        }

        public void BuySugar(int amountToBuy)
        {
            sugarStore += amountToBuy;
            double amountToPay = amountToBuy * 0.1;
            income -= amountToPay;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Inventory: {0} candies, {1} lollipops, Income: {2}, Sugar: {3}gr", 
                listOfCandies.Count, listOfLollypops.Count, income, sugarStore);
        }
    }
}
