using System;

namespace Thread
{
    class Program
    {
        static void Main()
        {
            int r = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = Math.Sqrt(double.Parse(arr[0]));
            }
            sum += 2 * Math.PI * r * r;
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
