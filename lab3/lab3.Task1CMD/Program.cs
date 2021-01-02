using lab3.BL;
using System;

namespace lab3.CMD
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter argument: ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                Task1 task1 = new Task1(x);
                Console.WriteLine(task1.GetValueOfFunction());
            }
            else
                Console.WriteLine("Value of argument has wrong format");
        }
    }
}
