namespace lab5.BL
{
    public class Task3Logic
    {
        private readonly double[,] array;
        public Task3Logic(double[,] array)
        {
            this.array = array;
        }
        public int CountRowsWithCondition()
        {
            int countResult = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int negativeCounter = 0;
                int pozitiveCounter = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                        pozitiveCounter++;
                    else if (array[i, j] < 0)
                        negativeCounter++;
                }
                if (pozitiveCounter > negativeCounter)
                    countResult++;
            }
            return countResult;
        }

    }
}
