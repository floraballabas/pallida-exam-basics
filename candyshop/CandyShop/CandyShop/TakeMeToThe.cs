﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopApp
{
    class TakeMeToThe
    {
        static void Main(string[] args)
        {
            // We run a Candy shop where we sell candies and lollipops
            // One lollipop's price is 10$
            // And it made from 5gr of sugar
            // One candie's price is 20$
            // And it made from 10gr of sugar
            // we can raise their prices with a given percentage

            // Create a CandyShop class
            // It can store sugar and money as income. The constructor should take the amount of sugar in gramms.
            // we can create lollipops and candies store them in the CandyShop's storage
            // If we create a candie or lollipop the CandyShop's sugar amount gets reduced by the amount needed to create the sweets
            // We can raise the prices of all candies and lollipops with a given percentage
            // We can sell candie or lollipop with a given number as amount
            // If we sell sweets the income will be increased by the price of the sweets and we delete it from the inventory
            // We can buy sugar with a given number as amount. The price of 1000gr sugar is 100$
            // If we buy sugar we can raise the CandyShop's amount of sugar and reduce the income by the price of it.
            // The CandyShop should print properties represented as string in this format:
            // "Inventory: 3 candies, 2 lollipops, Income: 100, Sugar: 400gr"
            var candyShop = new CandyShop(300);

            candyShop.CreateCandies();
            candyShop.CreateCandies();
            candyShop.CreateCandies();
            candyShop.CreateCandies();
            candyShop.CreateCandies();
            candyShop.CreateLollypops();
            candyShop.CreateLollypops();
            candyShop.CreateLollypops();

            candyShop.PrintInfo();
            candyShop.SellSweets("candy", 2);
            candyShop.SellSweets("lollypop", 1);
            candyShop.PrintInfo();

            candyShop.RaisePrices(1.1);
            candyShop.SellSweets("candy", 2);
            candyShop.SellSweets("lollypop", 1);

            candyShop.PrintInfo();

            candyShop.BuySugar(58);

            candyShop.PrintInfo();

            Console.ReadLine();
        }
    }
}
