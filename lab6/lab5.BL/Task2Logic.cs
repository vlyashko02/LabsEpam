namespace lab5.BL
{
    public class Task2Logic
    {
        private readonly double[] array;
        private int firstZeroElement = -1;
        private int secondZeroElement = -1;
        public Task2Logic(double[] array)
        {
            this.array = array;
        }
        public bool CondiditionIsMet()
        {
            int num1 = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    num1 = i;
                    break;
                }
            }
            int num2 = -1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == 0)
                {
                    num2 = i;
                    break;
                }
            }
            if (num2 != num1 && num1 != -1 && num2 != -1)
            {
                firstZeroElement = num1;
                secondZeroElement = num2;
                return true;
            }
            else
                return false;
        }
        public double SumWithCondidition()
        {
            double sum = 0;
            for (int i = firstZeroElement + 1; i < secondZeroElement; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
