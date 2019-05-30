using System;

namespace EveryDayWork
{
    class Programm
    {
        static void Main()
        {
            string[] nums = Console.ReadLine().Split(' ');
            long n = int.Parse(nums[0]);
            long m = int.Parse(nums[1]);
            if (0 <= n && n <= 40000)
            {
                if (0 <= m && m <= 40000)
                {
                    Console.WriteLine(n * (m + 1));
                }
            }
        }
    }
}