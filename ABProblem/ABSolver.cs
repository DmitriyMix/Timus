namespace Solver
{
    //1000+
    class ABSolver
    {
        private readonly int a;
        private readonly int b;

        public ABSolver(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public int Solve()
        {
            return a + b;
        }

    }
}
