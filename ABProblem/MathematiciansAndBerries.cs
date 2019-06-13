using System;

namespace MathematiciansAndBerries
{
    //2001+
    class Program
    {
        static void Main()
        {
            string[] values = Console.ReadLine().Split(' ');
            int a1 = int.Parse(values[0]);
            int b1 = int.Parse(values[1]);
            string[] values1 = Console.ReadLine().Split(' ');
            int a2 = int.Parse(values1[0]);
            int b2 = int.Parse(values1[1]);
            string[] values2 = Console.ReadLine().Split(' ');
            int a3 = int.Parse(values2[0]);
            int b3 = int.Parse(values2[1]);
            Console.WriteLine(a1 - a3);
            Console.WriteLine(b1 - b2);
        }
    }
}
