using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopApp
{
    public class Candies : Sweets
    {

        public Candies(double percentage)
        {
            this.price = 20 * percentage;
            this.sugar = 10;
        }
    }
}
