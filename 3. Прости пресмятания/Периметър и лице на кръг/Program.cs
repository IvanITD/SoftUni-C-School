﻿using System;
using System.Runtime.InteropServices;

namespace Периметър_и_лице_на_кръг
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine($"Area = {area:F2}");
            Console.WriteLine($"Perimeter = {perimeter:F2}");


        }
    }
}
