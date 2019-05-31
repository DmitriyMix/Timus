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
                int task = ((12 - f) * 45) - 240;

                var s = task > 0 ? "YES" : "NO";
                Console.WriteLine(s);
            }
        }
    }

}
