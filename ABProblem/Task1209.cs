using System;

namespace Task1209
{
    //1209+
    class Program
    {
        static void Main()
        {
            long n = Convert.ToInt64(Console.ReadLine());
            long[] k = new long[n];
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = Convert.ToInt64(Console.ReadLine());
            }
            for (int i = 0; i < k.Length; i++)
            {
                double a = (Math.Sqrt((8 * k[i]) - 7) - 1) / 2;
                long b = (int)a;
                if (a == b)
                {
                    Console.WriteLine("1 ");
                }
                else
                {
                    Console.WriteLine("0 ");
                }
            }

        }

    }
}



