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
    public class ArrayCalcs
    {
        public static double Sum(params double[] array)
        {
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static double Average(params double[] array)
        {
            double average = array.Average();
            average = Math.Round(average, 2);
            return average;
        }

        public static double Minimum(params double[] array)
        {
            double min = array.Min();
            return min;
        }

        public static double Maximum(params double[] array)
        {
            double max = array.Max();
            return max;
        }
    }
}
