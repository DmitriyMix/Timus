using System;
using System.Linq;

namespace DemocracyAtRisk
{
    //1025+
    class Program
    {
        static void Main()
        {
            double Res = 0;
            int n = int.Parse(Console.ReadLine());
            var numb = Console.ReadLine().Split(' ').Select(token => int.Parse(token));
            int[] a = numb.ToArray();
            Array.Sort(a);
            double ng = Math.Ceiling(a.Length / 2.0);
            for (int i = 0; i < ng; ++i)
            {
                Res += (Math.Ceiling(a[i] / 2.0));
            }
            Console.WriteLine(Res);
        }
    }
}
