using lab6.BL;
using System;

namespace lab6.Task2
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter birth year: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
                throw new ArgumentException("Year should be an integer.");
            else if (year < 0)
                throw new ArgumentException("Year should be greater than zero.");
            Console.Write("Enter score: ");
            if (!int.TryParse(Console.ReadLine(), out int score))
                throw new ArgumentException("Year should be an integer.");
            else if (score < 0)
                throw new ArgumentException("Year should be greater than zero.");

            Task2Logic task2Logic = new Task2Logic();
            if (task2Logic.IsFormFound(surname, score))
            {
                var result = task2Logic.GetDate(surname, year, score);
                Console.WriteLine($"{result.Item1} - {result.Item2} - {result.Item3} - {result.Item4} - {result.Item5}");
            }
            else
                throw new ArgumentException("Form not found.");
        }
    }
}
