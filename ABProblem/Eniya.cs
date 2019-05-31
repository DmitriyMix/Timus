using System;

namespace Eniya
{
    class Program
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            if (1 <= N && N <= 100)
            {
                if (1 <= A && A <= 100)
                {
                    if (1 <= B && B <= 100)
                    {
                        Console.WriteLine((A * B) * N * 2);
                    }
                }
            }
        }
    }
}