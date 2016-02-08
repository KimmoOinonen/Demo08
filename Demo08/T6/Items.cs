using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Items
    {
        public string Customer { get; set; }

        private List<Item> items;

        public Items()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void PrintCart()
        {
            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public override string ToString()
        {
            return "Customer " + Customer + " invoice:";
        }
    }
}
