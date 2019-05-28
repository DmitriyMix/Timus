using System;

namespace ABProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.In.ReadToEnd();
            SquareRoot.MakeTest(s);
        }
    }
}
namespace Eniya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int N;
            do
            {
                A = int.Parse(Console.ReadLine());
            }
            while (A < 1 || A > 100);
            do
            {
                B = int.Parse(Console.ReadLine());
            }
            while (B < 1 || B > 100);
            do
            {
                N = int.Parse(Console.ReadLine());
            }
            while (N < 1 || N > 100);
            int R = ((A * B) * N) * 2;
            Console.WriteLine(R);
        }
    }
}
