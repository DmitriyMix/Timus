﻿using System;

namespace TwoBandits1
{
    //1409+
    class Program
    {
        private static void Main()
        {
            string[] i = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(i[0]) + int.Parse(i[1]) - int.Parse(i[0]) - 1);
            Console.WriteLine(int.Parse(i[0]) + int.Parse(i[1]) - int.Parse(i[1]) - 1);
        }
    }
}
