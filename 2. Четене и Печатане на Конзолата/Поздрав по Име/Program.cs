﻿using System;

namespace Поздрав_по_Име
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Hello, " + name + "!");
        }
    }
}
