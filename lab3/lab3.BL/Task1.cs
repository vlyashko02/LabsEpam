using System;

namespace lab3.BL
{
    public class Task1
    {
        readonly double x;
        readonly double y;

        public Task1(double x)
        {
            this.x = x;
            y = CalculateValue(x);
        }

        private double CalculateValue(double x)
        {
            if (x >= -8 && x < -5)
                return -3;
            else if (x >= -5 && x < -3)
                return (3 + x);
            else if (x >= -3 && x <= 3)
                return Math.Sqrt(9 - x * x);
            else if (x > 3 && x < 8)
                return ((3 * x - 9) / 5);
            else if (x >= 8 && x <= 10)
                return 3;
            else throw new ArgumentException("The function is not defined at this point");
        }
        public double GetValueOfFunction() => y;
    }
}
