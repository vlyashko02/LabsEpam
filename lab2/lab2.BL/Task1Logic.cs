using System;

namespace lab2.BL
{
    public class Task1Logic
    {
        readonly double newtonRoot;
        readonly double systemRoot;
        readonly double differenceRoot;

        public Task1Logic(double number, int degree, double accuracy)
        {
            newtonRoot = NewtonMethod(number, degree, accuracy);
            systemRoot = Math.Pow(number, (double)1 / degree);
            differenceRoot = Math.Abs(newtonRoot - systemRoot);
        }
        private double NewtonMethod(double number, int degree, double accuracy)
        {
            var initialAssumption = number / degree;
            var nextAssumption = (1 / (double)degree) * ((double)(degree - 1) * initialAssumption + number / Pow(initialAssumption, (int)degree - 1));

            while (Math.Abs(nextAssumption - initialAssumption) > accuracy)
            {
                initialAssumption = nextAssumption;
                nextAssumption = (1 / (double)degree) * ((double)(degree - 1) * initialAssumption + number / Pow(initialAssumption, (int)degree - 1));
            }
            return nextAssumption;
        }
        private double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }
        public double GetNewtonRoot()
        {
            return newtonRoot;
        }
        public double GetDifferenceRoot()
        {
            return differenceRoot;
        }
        public double GetSystemRoot()
        {
            return systemRoot;
        }
    }
}
