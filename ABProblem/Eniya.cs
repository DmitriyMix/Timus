using System;

namespace Eniya
{
    //1293+
    class Program
    {
        static void Main()
        {
            string[] values = Console.ReadLine().Split(' ');
            int n = int.Parse(values[0]);
            int a = int.Parse(values[1]);
            int b = int.Parse(values[2]);
            Console.WriteLine(( a * b * n) * 2);
        }
    }
}
             

