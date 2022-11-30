﻿using System;
using System.Globalization;
using System.Security.Cryptography;

namespace _1000_дни_на_Земята
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime dateResult = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            dateResult = dateResult.AddDays(999);
            Console.WriteLine(dateResult.ToString("dd-MM-yyyy"));

            
        }
    }
}
