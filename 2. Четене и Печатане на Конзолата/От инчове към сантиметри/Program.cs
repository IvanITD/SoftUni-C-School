﻿using System;

namespace От_инчове_към_сантиметри
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            double inch = double.Parse(Console.ReadLine());
            double centimeters = inch * 2.54;
            Console.WriteLine("centimeters = " + centimeters);
        }
    }
}
