using lab5.BL;
using System;

namespace lab5.Task3
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter count of rows: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n > 0)
                {
                    Console.Write("Enter count of columns: ");
                    if (int.TryParse(Console.ReadLine(), out int m))
                    {
                        if (m > 0)
                        {
                            double[,] array = new double[n, m];
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < m; j++)
                                {
                                    Console.Write($"Enter {i + 1},{j + 1} element: ");
                                    if (!double.TryParse(Console.ReadLine(), out array[i, j]))
                                        throw new ArgumentException("Not a double.");
                                }
                            }
                            Task3Logic task3Logic = new Task3Logic(array);
                            Console.WriteLine($"Count rows: {task3Logic.CountRowsWithCondition()}");
                        }
                        else
                            throw new ArgumentException("Count must be greater than zero.");
                    }
                    else
                        throw new ArgumentException("Not an integer.");
                }
                else
                    throw new ArgumentException("Count must be greater than zero.");
            }
            else
                throw new ArgumentException("Not an integer.");
        }
    }
}
