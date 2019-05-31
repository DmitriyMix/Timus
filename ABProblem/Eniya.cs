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
            if (1 <= n && n <= 100 && 1 <= a && a <= 100 && 1 <= b && b <= 100)
            {
                Console.WriteLine((a * b) * n * 2);
            }
        }
    }
}