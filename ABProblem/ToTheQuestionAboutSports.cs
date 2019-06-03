using System;

namespace ToTheQuestionAboutSports
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                int x = i;
                int y = 0;
                while (x >= 0 && x <= n)
                {
                    Console.WriteLine(a[x][y] + " ");
                    x--;
                    y++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                int x = n - 1;
                int y = i + 1;
                while (y >= 1 && y < n)
                {
                    Console.WriteLine(a[x][y] + " ");
                    x--;
                    y++;
                }
            }
        }
    }
}










