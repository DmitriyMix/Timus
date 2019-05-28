using System;

namespace ABProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var s = Console.ReadLine();

            var ss = s.Split(' ');

            var a = int.Parse(ss[0]);
            var b = int.Parse(ss[1]);

            var r = new Solver.ABSolver(a, b).Solve();

            Console.WriteLine(r);
        }
    }
}


namespace Solver
{
}
