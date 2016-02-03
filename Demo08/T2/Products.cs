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
    class Products
    {
        private List<Product> products;
        public Products()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void Print()
        {
            Console.WriteLine("All products in shopping cart:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
