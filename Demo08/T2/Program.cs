/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 3.2.2016
 * Author: Kimmo Oinonen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Products cart = new Products();

            Product product1 = new Product { Name = "Milk", Price = 1.05 };
            Product product2 = new Product { Name = "Bread", Price = 1.95 };
            Product product3 = new Product { Name = "Butter", Price = 2.25 };

            cart.AddProduct(product1);
            cart.AddProduct(product2);
            cart.AddProduct(product3);

            cart.Print();
        }
    }
}
