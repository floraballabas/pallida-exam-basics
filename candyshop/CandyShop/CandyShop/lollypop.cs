using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopApp
{
    public class Lollypop : Sweets
    {
        public Lollypop(double percentage)
        {
            this.price = 10 * percentage;
            this.sugar = 5;
        }
    }
}
