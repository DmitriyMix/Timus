using System;

namespace Eniya
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (1 <= n && n <= 100)
            {
                if (1 <= a && a <= 100)
                {
                    if(1 <= b && b <= 100)
                    {
                        int s = a * b * n * 2;
                        Console.WriteLine(s);
                    }

                }                                          
            }
        }
    }
}