using System;

namespace Thread
{
    class Program
    {
        class Coords
        {
            public Coords(double _x, double _y)
            {
                x = _x;
                y = _y;
            }
            public readonly double x;
            public readonly double y;
        }
        static void Main()
        {

            string[] arr = Console.ReadLine().Split(' ');
            int n = int.Parse(arr[0]);
            int r = int.Parse(arr[1]);
            int value = 2;
            double sum = 0;
            var c = new Coords[n];
            for (int i = 0; i < n; i++)
            {
                arr = Console.ReadLine().Split(' ');
                c[i] = new Coords(double.Parse(arr[0]), double.Parse(arr[1]));

            }
            foreach (var m in c)
            {
                var l = (m.x - m.x);
                var t = (m.x - m.x);
                var b = (m.y - m.y);
                var z = (m.y - m.y);
                var g = Math.Pow(value, t);
                var h = Math.Pow(value, z);
                var a = Math.Pow(value, l);                                                                             
                var p = Math.Pow(value, b);                
                var f = p + a + g + h;
                var u = Math.Sqrt(f);//(l*l+h*h);                
                sum = 4 * u + (2 * Math.PI * r);
            }
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
