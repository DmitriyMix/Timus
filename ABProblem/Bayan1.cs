using System;
using System.Collections.Generic;


namespace Bayan1
{
    //1563+
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int count = 0;
            var shop = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                if (!shop.Contains(s))
                {
                    shop.Add(s);
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

    }
}
