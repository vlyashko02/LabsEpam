using System;

namespace lab3.BL
{
    public class Task2
    {
        public readonly int Count;
        readonly double xStart;
        readonly double xEnd;
        readonly double dx;
        readonly double epsilon;

        public double[] ArgumentValue { get; private set; }
        public double[] FunctionValue { get; private set; }
        public int[] Steps { get; private set; }
        public double[] RealFunctionValue { get; private set; }

        public Task2(double xStart, double xEnd, double dx, double epsilon)
        {
            this.xStart = xStart;
            this.xEnd = xEnd;
            this.dx = dx;
            this.epsilon = epsilon;
            Count = (int)(Math.Round((Math.Round(xEnd - xStart, 7)) / dx, 7)) + 1;

            ArgumentValue = new double[Count];
            FunctionValue = new double[Count];
            Steps = new int[Count];
            RealFunctionValue = new double[Count];

            Calculate();
        }
        public void Calculate()
        {
            int count = 0;
            double y, a;
            int n;
            for (double x = xStart; Math.Round(x, 7) <= xEnd; x += dx)
            {
                x = Math.Round(x, 7);
                y = 0; a = 1;
                for (n = 1; Math.Abs(a) >= epsilon; n++)
                {
                    a = Math.Pow(x, n) / n;
                    y -= a;
                }

                ArgumentValue[count] = x;
                FunctionValue[count] = y;
                Steps[count] = n;
                RealFunctionValue[count] = Math.Log(1 - x);

                count++;
            }
        }
    }
}
