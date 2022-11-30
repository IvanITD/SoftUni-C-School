﻿using System;

namespace Междувалутен_конвертор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double sum = double.Parse(Console.ReadLine());
                string firstSum = Console.ReadLine();
                string secondSum = Console.ReadLine();
                double bgn, usd, eur, gbp;

                if (firstSum == "BGN")      //BGN to USD, EUR, GBP
                {
                    if (secondSum == "USD")
                    {
                        usd = sum / 1.79549;
                        Console.WriteLine($"{usd:f2} USD");
                    }
                    else if (secondSum == "EUR")
                    {
                        eur = sum / 1.95583;
                        Console.WriteLine($"{eur:F2} EUR");
                    }
                    else if (secondSum == "GBP")
                    {
                        gbp = sum / 2.53405;
                        Console.WriteLine($"{gbp:F2} GBP");
                    }
                    else if (secondSum == "BGN")
                    {
                        Console.WriteLine($"{sum:F2} BGN");
                    }

                }
                else if (firstSum == "USD")     //USD to BGN, EUR, GBP
                {
                    if (secondSum == "BGN")
                    {
                        bgn = sum * 1.79549;
                        Console.WriteLine($"{bgn:F2} BGN");
                    }
                    else if (secondSum == "EUR")
                    {
                        eur = sum * 1.79549 / 1.95583;
                        Console.WriteLine($"{eur:F2} EUR");
                    }
                    else if (secondSum == "GBP")
                    {
                        gbp = sum * 1.79549 / 2.53405;
                        Console.WriteLine($"{gbp:F2} GBP");
                    }
                    else if (secondSum == "USD")
                    {
                        Console.WriteLine($"{sum:F2} USD");
                    }
                }
                else if (firstSum == "EUR")     //EUR to BGN, USD, GBP
                {
                    if (secondSum == "BGN")
                    {
                        bgn = sum * 1.95583;
                        Console.WriteLine($"{bgn:F2} BGN");
                    }
                    else if (secondSum == "USD")
                    {
                        usd = sum * 1.95583 / 1.79549;
                        Console.WriteLine($"{usd:F2} USD");
                    }
                    else if (secondSum == "GBP")
                    {
                        gbp = sum * 1.95583 / 2.53405;
                        Console.WriteLine($"{gbp:F2} GBP");
                    }
                    else if (secondSum == "EUR")
                    {
                        Console.WriteLine($"{sum:F2} EUR");
                    }
                }
                else if (firstSum == "GBP") // GBP to BGN, USD, EUR
                {
                    if (secondSum == "BGN")
                    {
                        bgn = sum * 2.53405;
                        Console.WriteLine($"{bgn:F2} BGN");
                    }
                    else if (secondSum == "USD")
                    {
                        usd = sum * 2.53405 / 1.79549;
                        Console.WriteLine($"{usd:F2} USD");
                    }
                    else if (secondSum == "EUR")
                    {
                        eur = sum * 2.53405 / 1.95583;
                        Console.WriteLine($"{eur:F2} EUR");
                    }
                    else if (secondSum == "GBP")
                    {
                        Console.WriteLine($"{sum:F2} GBP");
                    }
                }   
            }
        }
    }
}