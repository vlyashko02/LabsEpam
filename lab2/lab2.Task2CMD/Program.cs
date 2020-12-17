using lab2.BL;
using System;

namespace lab2.Task2CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer and greater than zero");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if(number >= 0)
                {
                    Task2Сonverter converter = new Task2Сonverter(number);
                    Console.WriteLine($"Binary performance: {converter.GetBinaryNumber()}");
                }
                else
                    Console.WriteLine("The entered number is less than zero");
            }
            else
                Console.WriteLine("The entered string is not an integer");
        }
    }
}
