﻿using System;

namespace Конвертор_от_радиани_в_градуси
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;
            degrees = Math.Round(degrees);
            
            Console.WriteLine(degrees);
        }
    }
}
