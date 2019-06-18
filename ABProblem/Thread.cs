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
            double j = 0.49;
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
                var h = (m.y - m.y);
                var k = Math.Pow(value, l);
                var v = Math.Pow(value, h);
                var f = k + v;
                var u = Math.Sqrt(f);

                //Console.WriteLine(u);
                sum =u + (2 * Math.PI * r * r);

                //foreach (var t in c)
                {
                  
                }



            }
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
