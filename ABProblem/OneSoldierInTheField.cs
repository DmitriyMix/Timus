using System;

namespace OneSoldierInTheField
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string s2 = "";
            for (int i = 1; i < n;i++)
            {
                string s1 = Console.ReadLine();
                if (s1 == "a1" || s1 == "h1" || s1 == "a8" || s1 == "h8") s2 = s2 + 2 + " ";
                else if (s1 == "b1" || s1 == "g1" || s1 == "b8" || s1 == "g8" || s1 == "a2" || s1 == "h2" || s1 == "a7" || s1 == "h7") s2 = s2 + 3 + " ";
                else if (s1 == "b2" || s1 == "g2" || s1 == "b7" || s1 == "g7" || s1 == "a3" || s1 == "h3" || s1 == "a6" || s1 == "h6" || s1 == "c1" || s1 == "f1" || s1 == "d1" || s1 == "e1" || s1 == "c8" || s1 == "f8" || s1 == "d8" || s1 == "e8" || s1 == "a4" || s1 == "h4" || s1 == "a5" || s1 == "h5") s2 = s2 + 4 + " ";
                else if (s1 == "b3" || s1 == "g3" || s1 == "b6" || s1 == "g6" || s1 == "c2" || s1 == "f2" || s1 == "d2" || s1 == "e2" || s1 == "c7" || s1 == "f7" || s1 == "d7" || s1 == "e7" || s1 == "b4" || s1 == "g4" || s1 == "b5" || s1 == "g5") s2 = s2 + 6 + " ";
                else s2 = s2 + 8 + " ";
            }
            Console.WriteLine(s2);
        }
    }
}
