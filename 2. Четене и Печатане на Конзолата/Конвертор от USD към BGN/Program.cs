﻿using System;

namespace Конвертор_от_USD_към_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;

            Console.WriteLine($"{bgn:F2} BGN");
        }
    }
}
