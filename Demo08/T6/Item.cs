using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        private double total;
        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = Price * Quantity;
            }
        }

        public override string ToString()
        {
            return Name + "   " + Price + "e   " + Quantity + " pieces   " + Total + "e total";
        }
    }
}
