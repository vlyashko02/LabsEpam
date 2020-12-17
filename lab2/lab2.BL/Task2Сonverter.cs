using System;

namespace lab2.BL
{
    public class Task2Сonverter
    {
        readonly int decimalNumber;
        readonly string binaryNumber;

        public Task2Сonverter(int number)
        {
            if(Validation(number))
            {
                decimalNumber = number;
                binaryNumber = Convert.ToString(number, 2);
            }
        }
        private bool Validation(int number)
        {
            return number >= 0;
        }
        public string GetBinaryNumber()
        {
            return binaryNumber;
        }
    }
}
