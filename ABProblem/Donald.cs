using System;

namespace Donald
{
    //2023+
    class Programm
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 0;
            for (int z = 1; z <= n; z++)
            {
                string str1 = Console.ReadLine();
                for (int f = 1; f <= n; f++)
                {
                    if (str1[0] == 'A' || str1[0] == 'P' || str1[0] == 'O' || str1[0] == 'R')
                    {
                        if (num == 1) sum += 0;
                        else if (num == 2) sum += 1;
                        else if (num == 3) sum += 2;
                        num = 1;
                        break;
                    }
                    else if (str1[0] == 'B' || str1[0] == 'M' || str1[0] == 'S')
                    {
                        if (num == 1) sum += 1;
                        else if (num == 2) sum += 0;
                        else if (num == 3) sum += 1;
                        num = 2;
                        break;
                    }
                    else if (str1[0] == 'D' || str1[0] == 'G' || str1[0] == 'J' || str1[0] == 'K' || str1[0] == 'T' || str1[0] == 'W')
                    {
                        if (num == 1) sum += 2;
                        else if (num == 2) sum += 1;
                        else if (num == 3) sum += 0;
                        num = 3;
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
