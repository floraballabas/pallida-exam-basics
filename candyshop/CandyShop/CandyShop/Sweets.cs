using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopApp
{
    public class Sweets
    {
        protected double price;
        protected double sugar;

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public double Sugar
        {
            get
            {
                return sugar;
            }
            set
            {
                sugar = value;
            }
        }
    }
}
