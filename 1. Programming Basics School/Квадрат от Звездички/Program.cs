﻿namespace Квадрат_от_Звездички
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(new String('*', N));

            for (int i = 1; i <= N-2; i++)
            {
                Console.Write("*");
                Console.Write(new String(' ',N-2));
                Console.WriteLine("*");
            }
            Console.WriteLine(new String('*', N));
        }
    }
}