using System;

namespace Factorial
{
    //1083+
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int l = input[1].Length;
            int i = 0;
            int f = 1;
            int m = 1;
            while (m >= 1)
            {
                f *= m;
                m = n - (i * l);                
                i++;
            }
            Console.WriteLine(f);
        }
    }
}
