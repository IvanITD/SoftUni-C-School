﻿using System;

namespace Конвертор_от__C_към__F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            //F = [(C*9)/5] + 32
            double fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine(fahrenheit);
        }
    }
}
