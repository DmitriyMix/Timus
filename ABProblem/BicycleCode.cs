using System;

namespace BikcycleCode
{
	class Program
	{
        static void Main()
        {
            int code1 = int.Parse(Console.ReadLine());
            int code2 = int.Parse(Console.ReadLine());
            if (code1 % 2 == 0 || code2 % 2 != 0)
                Console.WriteLine("yes");
            else if (code1 % 2 != 0 || code2 % 2 == 0)
                Console.WriteLine("no");
        }
	}
}
