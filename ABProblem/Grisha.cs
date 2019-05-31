using System;

namespace Grisha
{
    class Program
    {
        static void Main()
        {
            int f = int.Parse(Console.ReadLine());
            if (1 <= f && f <= 11)
            {
                if (f > 7)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }

}
