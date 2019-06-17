using System;
using System.Collections.Generic;


namespace Bayan1
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int count = 0;
            var shop = new HashSet<string>
            {
                Console.ReadLine()
            };
            //foreach (string s in shop)
            for( var s = 0; s <= n; s++)
            {
                if (shop.Equals(shop))
                {
                    count++;
                }
                else if (!shop.Equals(shop))
                {
                    shop.Add();
                }
            }
            Console.WriteLine(count);
        }

    }
}
