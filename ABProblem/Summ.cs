using System;

namespace Summ
{
    //1068+
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.In.ReadLine());
            (int start, int end) = n > 1 ? (1, n) : (n, 1);
            int sum = 0;
            for (int i = start; i <= end; i++)
                sum += i;
            Console.WriteLine(sum);
        }
    }
}

