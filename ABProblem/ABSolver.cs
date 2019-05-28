namespace Solver
{
    class ABSolver
    {
        private int a;
        private int b;

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
