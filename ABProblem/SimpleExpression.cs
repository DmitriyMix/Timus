﻿using System;

namespace SimpleExpression
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Min((a - b * c), (a - b - c)));
        }
    }
}