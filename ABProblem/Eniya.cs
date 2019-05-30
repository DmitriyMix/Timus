using System;

namespace Eniya
{
    class Program
    {
        private static void Main()
        {

            int N;
            int A;
            int B;

            do
            {
                A = int.Parse(Console.ReadLine());
            }
            while (A > 1 && A < 100);
            
            do
            {
                B = int.Parse(Console.ReadLine());
            }
            while (B > 1 && B < 100);
            do
            {
                N = int.Parse(Console.ReadLine());
            }
            while (N > 1 && N < 100);
            int R = ((A * B) * N) * 2;
            Console.WriteLine(R);
            
        }
    }
}