using System;

namespace Grisha
{
    //2012+
    class Program
    {
        static void Main()
        {
            int f = int.Parse(Console.ReadLine());
            if (1 <= f && f <= 11)
            {
                int task = 4 * 60 - ((12 - f) * 45);

                var s = task > 0 ? "YES" : "NO";
                Console.WriteLine(s);
            }
        }
    }

}
