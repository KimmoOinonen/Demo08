/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 7.2.2016
 * Author: Kimmo Oinonen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Console.WriteLine("Sum = " + ArrayCalcs.Sum(array));
            Console.WriteLine("Average = " + ArrayCalcs.Average(array));
            Console.WriteLine("Min = " + ArrayCalcs.Minimum(array));
            Console.WriteLine("Max = " + ArrayCalcs.Maximum(array));

            Console.ReadLine();
        }
    }
}
