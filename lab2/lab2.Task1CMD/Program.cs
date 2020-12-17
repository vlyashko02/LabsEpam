using lab2.BL;
using System;

namespace lab2.Task1CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                Console.Write("Enter degree: ");
                if (int.TryParse(Console.ReadLine(), out int degree))
                {
                    Console.Write("Enter accuracy: ");
                    if (double.TryParse(Console.ReadLine(), out double accuracy))
                    {
                        Task1Logic task = new Task1Logic(number, degree, accuracy);
                        Console.WriteLine($"Newton method result: {task.GetNewtonRoot()}");
                        Console.WriteLine($"System method result: {task.GetSystemRoot()}");
                        Console.WriteLine($"Difference in results: {String.Format("{0:0.#################}", task.GetDifferenceRoot())}");
                    }
                    else
                        Console.WriteLine("Invalid format. Should be '0,#...#'");
                }
                else
                    Console.WriteLine("Invalid format. Should be integer");
            }
            else
                Console.WriteLine("Invalid format. Should be integer or double");
        }
    }
}
