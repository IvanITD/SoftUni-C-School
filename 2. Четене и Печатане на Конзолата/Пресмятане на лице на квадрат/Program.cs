﻿using System;

namespace Пресмятане_на_лице_на_квадрат
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            Console.WriteLine("Square = " + area);
        }
    }
}
