using System;

namespace MathematiciansAndBerries
{
    class Program
    {
        static void Main()
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());
            Console.WriteLine("1 - " + (a2 - a1 - a3));
            Console.WriteLine("2 - " + (b1 - b2));
        }
    }
}
