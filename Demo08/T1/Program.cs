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

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            int num = dice.Throw();
            //Console.WriteLine("Number is {0}", num);

            Console.WriteLine("How many times you want to throw dice: ");
            string line = Console.ReadLine();
            int times;
            bool success = int.TryParse(line, out times);
            if (success)
            {
                Random rand = new Random();
                int[] collection = new int[times];
                for (int i = 1; i < times; i++)
                {
                    collection[i] = num;
                }
                double avrg = collection.Average();

                Console.WriteLine("Dice is thrown " + times + " average is " + avrg);
            } else
            {
                Console.WriteLine("You didn't gave number");
            }
        }
    }
}
