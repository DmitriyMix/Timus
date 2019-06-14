using System;
using System.Collections.Generic;


namespace Bayan1
{
    class Program
    {
        static void Main()
        {
            int count = 0;           
            var shop = new HashSet<string>
            {
                Console.ReadLine()
            };
            foreach (var s in shop)
            {
                if (!shop.Contains(s))
                {
                    count++;
                }
                else if (shop.Contains(s))
                {
                    shop.Add(s);
                }
            }           
            Console.WriteLine(count);
        }

    }
}
