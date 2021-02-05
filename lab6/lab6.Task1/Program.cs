using System;

namespace lab6.Task1
{
    class Program
    {
        static void Main()
        {
            string userInput = "";
            while (userInput != "exit")
            {
                Console.Clear();
                Menu();
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        lab5.Task1.Program.Main();
                        Console.ReadLine();
                        break;
                    case "2":
                        lab5.Task2.Program.Main();
                        Console.ReadLine();
                        break;
                    case "3":
                        lab5.Task3.Program.Main();
                        Console.ReadLine();
                        break;
                    case "4":
                        Task2.Program.Main();
                        Console.ReadLine();
                        break;
                    case "exit":
                        Console.WriteLine("Exit...");
                        break;
                    default:
                        Console.WriteLine("It's not a number of task. Press enter to continue and try again");
                        Console.ReadLine();
                        break;
                }
            }
        }
        private static void Menu()
        {
            Console.WriteLine("Choose the Task");
            Console.WriteLine("1 - First Task");
            Console.WriteLine("2 - Second Task");
            Console.WriteLine("3 - Third Task");
            Console.WriteLine("4 - Struct Task");
            Console.WriteLine("If you want to exit enter 'exit' ");
        }
    }
}
