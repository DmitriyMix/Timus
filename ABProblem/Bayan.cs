using System;

namespace bayan
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] shop = new string[n];
            int x = 0;
            for(int i = 0; i< n; i++)
            {
                shop[i] = Console.ReadLine();
            }
            for (int i = 0; i<shop.Length; i++)
            {
                for(int k = i+1; k <shop.Length;k++)
                {
                    if(shop[i] == shop[k])
                    {
                        x++;
                        i--;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(x);
                  
        }
    }
}
