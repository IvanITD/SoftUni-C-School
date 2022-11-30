using System;

namespace Лице_на_триъгълник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = side * height / 2;

            Console.WriteLine($"Triangle area = {Math.Round(area, 2)}");

        }
    }
}
