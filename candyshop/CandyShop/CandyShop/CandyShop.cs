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
    }
}
