using System;

namespace Penguin
{
    //1585+
    class Program
    {
        static void Main()
        {
            int Emperor = 0, Little = 0, Macaroni = 0;
            int max = int.Parse(Console.ReadLine());
            string[] s = new string[max];
            for (int t = 0; t <= max - 1; t++)
            {
                s[Convert.ToInt32(t)] = (Console.ReadLine());
            }
            for (int v = 0; v <= max - 1; v++)
            {
                if (s[v] == "Emperor Penguin")
                {
                    Emperor++;
                }
                if (s[v] == "Macaroni Penguin")
                {
                    Macaroni++;
                }
                if (s[v] == "Little Penguin")
                {
                    Little++;
                }
            }
            if(Emperor > Macaroni && Emperor > Little)
            {
                Console.WriteLine("Emperor Penguin");
            }
            if (Macaroni > Emperor && Macaroni > Little)
            {
                Console.WriteLine("Macaroni Penguin");
            }
            if (Little > Emperor && Little > Macaroni)
            {
                Console.WriteLine("Little Penguin");
            }
        }
    }
}





