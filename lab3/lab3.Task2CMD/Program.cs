using lab3.BL;
using System;

namespace lab3.Task2CMD
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter start x: ");
            if(double.TryParse(Console.ReadLine(), out double xStart))
            {
                Console.Write("Enter end x: ");
                if(double.TryParse(Console.ReadLine(), out double xEnd))
                {
                    Console.Write("Enter dx: ");
                    if(double.TryParse(Console.ReadLine(), out double dx))
                    {
                        Console.Write("Enter epsilon: ");
                        if(double.TryParse(Console.ReadLine(), out double epsilon))
                        {
                            if(xEnd > xStart && epsilon > 0 && dx > 0 && dx < xEnd - xStart)
                            {
                                if(xStart >= -1 && xEnd < 1)
                                {
                                    Task2 task2 = new Task2(xStart, xEnd, dx, epsilon);
                                    Console.WriteLine("Table of function values");
                                    Console.WriteLine("|   x  |     y     |  Steps |  Real value  |");

                                    for (int i = 0; i < task2.Count; i++)
                                    {
                                        Console.WriteLine($"| {task2.ArgumentValue[i].ToString($"F2")} | {task2.FunctionValue[i].ToString($"F6")} |   {task2.Steps[i]}    |  {task2.RealFunctionValue[i].ToString($"F6")}");
                                    }
                                }
                                else
                                    Console.WriteLine("Argument should be >= -1 and < 1.");
                            }
                            else
                                Console.WriteLine("First argument < last argument\ndx > 0\nepsilon > 0\ndx < last argument - first argument.");
                        }
                        else
                            Console.WriteLine("Epsilon is double type");
                    }
                    else
                        Console.WriteLine("dx is double type");
                }
                else
                    Console.WriteLine("Last argument is double type");
            }
            else
                Console.WriteLine("First argument is double type");
        }
    }
}
