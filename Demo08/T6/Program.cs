using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Items cart = new Items { Customer = "Kirsi Kernel" };

            Item item1 = new Item { Name = "Milk", Price = 1.20, Quantity = 2 };
            Item item2 = new Item { Name = "Butter", Price = 2.20, Quantity = 1 };
            Item item3 = new Item { Name = "Bread", Price = 2.99, Quantity = 3 };

            cart.AddItem(item1);
            cart.AddItem(item2);
            cart.AddItem(item3);

            cart.PrintCart();
        }
    }
}
