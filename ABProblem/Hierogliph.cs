using System;

namespace Hierogliph
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] a = new string[n];
            for (int i = 0; i <= n - 1; i++)
            {
                a[i] = Console.ReadLine();
            }
            string b = Console.ReadLine();
            foreach (string d in a)
            {
                if (d.Substring(1, 1) == b)
                    Console.WriteLine(d);
            }
        }
    }
}

    


