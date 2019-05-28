using System;
using System.Globalization;

namespace ABProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.In.ReadToEnd();
            SquareRoot.MakeTest(s);
        }
    }
}

class SquareRoot
{
    public static void MakeTest(string s)
    {
        var ss = s.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < ss.Length; ++i)
        {
            //Console.WriteLine(ss[ss.Length - i - 1]);

            var x = double.Parse(ss[ss.Length - i - 1]);
            var y = string.Format(CultureInfo.InvariantCulture, "{0:0.0000}", Math.Sqrt(x));
            Console.WriteLine(y);
        }
    }
}
