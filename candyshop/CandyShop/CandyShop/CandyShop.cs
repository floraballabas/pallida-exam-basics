using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopApp
{
    public class CandyShop
    {
        private double sugarStore;
        private double income = 0;
        private List<Sweets> candyStore = new List<Sweets>();
        private List<Sweets> listOfCandies = new List<Sweets>();
        private List<Sweets> listOfLollypops = new List<Sweets>();

        public CandyShop(double sugarStore)
        {
            this.sugarStore = sugarStore;
        }

        public double SugarStore
        {
            get
            {
                return sugarStore;
            }
            set
            {
                sugarStore = value;
            }
        }

        public double Income
        {
            get
            {
                return income;
            }
            set
            {
                income = value;
            }
        }

        public List<Sweets> CandyStore
        {
            get
            {
                return candyStore;
            }
            set
            {
                candyStore = value;
            }
        }

        public List<Sweets> ListOfCandies
        {
            get
            {
                return listOfCandies;
            }
            set
            {
                listOfCandies = value;
            }
        }

        public List<Sweets> ListOfLollypops
        {
            get
            {
                return listOfLollypops;
            }
            set
            {
                listOfLollypops = value;
            }
        }

        public List<Sweets> CreateCandies()
        {
            var candyClass = new Candies();
            listOfCandies.Add(candyClass);
            sugarStore -= candyClass.Sugar;
            candyStore.Add(candyClass);
            return candyStore;
        }
        public List<Sweets> CreateLollypops()
        {
            var lollypopClass = new Lollypop();
            listOfLollypops.Add(lollypopClass);
            sugarStore -= lollypopClass.Sugar;
            candyStore.Add(lollypopClass);
            return candyStore;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Inventory: {0} candies, {1} lollipops, Income: {2}, Sugar: {3}gr", 
                listOfCandies.Count, listOfLollypops.Count, income, sugarStore);
        }
    }
}
