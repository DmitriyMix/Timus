using System;
using System.Globalization;

class SquareRoot
{
    //1001+
    public static void MakeTest(string s)
    {
        var ss = s.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < ss.Length; ++i)
        {
            var x = double.Parse(ss[ss.Length - i - 1]);
            var y = string.Format(CultureInfo.InvariantCulture, "{0:0.0000}", Math.Sqrt(x));
            Console.WriteLine(y);
        }
    }
}
