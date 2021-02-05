namespace lab5.BL
{
    public class Task1Logic
    {
        private readonly double[] array;
        public Task1Logic(double[] array)
        {
            this.array = array;
        }
        public double MaxElementArray()
        {
            double max = double.MinValue;

            foreach (var element in array)
            {
                if (max < element)
                    max = element;
            }
            return max;
        }
    }
}
