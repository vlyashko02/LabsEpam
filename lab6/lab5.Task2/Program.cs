using lab5.BL;
using System;

namespace lab5.Task2
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter count of elements: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n > 0)
                {
                    double[] array = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Enter {i + 1} element: ");
                        if (!double.TryParse(Console.ReadLine(), out array[i]))
                            throw new ArgumentException("Not a double.");
                    }
                    Task2Logic task2Logic = new Task2Logic(array);
                    if (task2Logic.CondiditionIsMet())
                        Console.WriteLine($"Result sum: {task2Logic.SumWithCondidition()}");
                    else
                        throw new Exception("Condidtion is not met.");
                }
                else
                    throw new ArgumentException("Count must be greater than zero.");
            }
            else
                throw new ArgumentException("Not an integer.");
        }
    }
}
