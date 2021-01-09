using lab4.BL;
using System;

namespace lab4.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4 Menu");
            Console.WriteLine("Press 1 to create constructor without parameters");
            Console.WriteLine("Press 2 to create constructor with parameters");
            if (!int.TryParse(Console.ReadLine(), out int k))
                throw new Exception("You should write 1 or 2.");
            switch(k)
            {
                case 1:
                    FirstKeyMenu();
                    break;
                case 2:
                    SecondKeyMenu();
                    break;
                default:
                    throw new ArgumentException("You should write 1 or 2.");
            }
        }
        private static void FirstKeyMenu()
        {
            TimeDisplay timeDisplay = new TimeDisplay();
            MainMenu(timeDisplay);
        }
        private static void SecondKeyMenu()
        {
            Console.Write("Enter hours: ");
            if (int.TryParse(Console.ReadLine(), out int hours))
            {
                if (hours >= 0 && hours <= 24)
                {
                    Console.Write("Enter minutes: ");
                    if (int.TryParse(Console.ReadLine(), out int minutes))
                    {
                        if (minutes >= 0 && minutes <= 60)
                        {
                            Console.Write("Enter seconds: ");
                            if (int.TryParse(Console.ReadLine(), out int seconds))
                            {
                                if (seconds >= 0 && seconds <= 60)
                                {
                                    TimeDisplay timeDisplay = new TimeDisplay(seconds, minutes, hours);
                                    MainMenu(timeDisplay);
                                }
                                else
                                    throw new ArgumentException("Seconds should be between 0 and 60.");
                            }
                            else
                                throw new ArgumentException("Seconds should be an integer.");
                        }
                        else
                            throw new ArgumentException("Minutes should be between 0 and 60.");
                    }
                    else
                        throw new ArgumentException("Minutes should be an integer.");
                }
                else
                    throw new ArgumentException("Hours should be between 0 and 24.");
            }
            else
                throw new ArgumentException("Hours should be an integer.");
        }
        private static void MainMenu(TimeDisplay timeDisplay)
        {
            Console.Clear();
            FormatViewTime(timeDisplay);
            Console.WriteLine();
            MenuView();
            string input = Console.ReadLine();

            while (input != "exit")
            {
                switch (input)
                {
                    case "1":
                        Console.Write("Set hours: ");
                        if (int.TryParse(Console.ReadLine(), out int hours))
                        {
                            timeDisplay.Hours = hours;
                        }
                        else
                            throw new ArgumentException("Hours should be an integer.");
                        break;
                    case "2":
                        Console.Write("Set minutes: ");
                        if (int.TryParse(Console.ReadLine(), out int minutes))
                        {
                            timeDisplay.Minutes = minutes;
                        }
                        else
                            throw new ArgumentException("Minutes should be an integer.");
                        break;
                    case "3":
                        Console.Write("Set seconds: ");
                        if (int.TryParse(Console.ReadLine(), out int seconds))
                        {
                            timeDisplay.Seconds = seconds;
                        }
                        else
                            throw new ArgumentException("Seconds should be an integer.");
                        break;
                    case "4":
                        Console.Write("Number of hours to add: ");
                        if (int.TryParse(Console.ReadLine(), out int hoursAdd))
                        {
                            if (hoursAdd > 0)
                                timeDisplay.ChangeHours(hoursAdd);
                        }
                        else
                            throw new ArgumentException("Hours should be an integer.");
                        break;
                    case "5":
                        Console.Write("Number of minutes to add: ");
                        if (int.TryParse(Console.ReadLine(), out int minutesAdd))
                        {
                            if (minutesAdd > 0)
                                timeDisplay.ChangeMinutes(minutesAdd);
                        }
                        else
                            throw new ArgumentException("Minutes should be an integer.");
                        break;
                    case "6":
                        Console.Write("Number of seconds to add: ");
                        if (int.TryParse(Console.ReadLine(), out int secondsAdd))
                        {
                            if (secondsAdd > 0)
                                timeDisplay.ChangeSeconds(secondsAdd);
                        }
                        else
                            throw new ArgumentException("Seconds should be an integer.");
                        break;
                }
                Console.Clear();
                FormatViewTime(timeDisplay);
                Console.WriteLine();
                MenuView();
                input = Console.ReadLine();
            }
        }
        private static void MenuView()
        {
            Console.WriteLine("1 - Set hours");
            Console.WriteLine("2 - Set minutes");
            Console.WriteLine("3 - Set seconds");
            Console.WriteLine("4 - Change hours");
            Console.WriteLine("5 - Change minutes");
            Console.WriteLine("6 - Change seconds");
            Console.WriteLine("exit - Close app");
        }
        private static void FormatViewTime(TimeDisplay timeDisplay)
        {
            if(timeDisplay.Hours < 10 && timeDisplay.Minutes < 10 && timeDisplay.Seconds < 10)
                Console.WriteLine($"Current time: 0{timeDisplay.Hours}:0{timeDisplay.Minutes}:0{timeDisplay.Seconds}");
            if (timeDisplay.Hours < 10 && timeDisplay.Minutes < 10 && timeDisplay.Seconds >= 10)
                Console.WriteLine($"Current time: 0{timeDisplay.Hours}:0{timeDisplay.Minutes}:{timeDisplay.Seconds}");
            if (timeDisplay.Hours < 10 && timeDisplay.Minutes >= 10 && timeDisplay.Seconds >= 10)
                Console.WriteLine($"Current time: 0{timeDisplay.Hours}:{timeDisplay.Minutes}:{timeDisplay.Seconds}");
            if (timeDisplay.Hours >= 10 && timeDisplay.Minutes >= 10 && timeDisplay.Seconds >= 10)
                Console.WriteLine($"Current time: {timeDisplay.Hours}:{timeDisplay.Minutes}:{timeDisplay.Seconds}");
            if (timeDisplay.Hours >= 10 && timeDisplay.Minutes >= 10 && timeDisplay.Seconds < 10)
                Console.WriteLine($"Current time: {timeDisplay.Hours}:{timeDisplay.Minutes}:0{timeDisplay.Seconds}");
            if (timeDisplay.Hours >= 10 && timeDisplay.Minutes < 10 && timeDisplay.Seconds < 10)
                Console.WriteLine($"Current time: {timeDisplay.Hours}:0{timeDisplay.Minutes}:0{timeDisplay.Seconds}");
            if (timeDisplay.Hours >= 10 && timeDisplay.Minutes < 10 && timeDisplay.Seconds >= 10)
                Console.WriteLine($"Current time: {timeDisplay.Hours}:0{timeDisplay.Minutes}:{timeDisplay.Seconds}");
        }
    }
}
