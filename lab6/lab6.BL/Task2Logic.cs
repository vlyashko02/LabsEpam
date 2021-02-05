using System;

namespace lab6.BL
{
    public class Task2Logic
    {
        readonly Form[] forms = new Form[]
        {
            new Form("Ricardo", "American", "New York, 11", 5, 6, 7),
            new Form("Johnta", "Belgian", "Tiscot, 28", 28, 11, 19),
            new Form("Crifot", "England", "London, 199", 17, 1, 9),
            new Form("Ivanov", "Belarusian", "Gomel, 77", 1, 188, 6),
            new Form("Petrov", "Russian", "Moscow, 14", 155, 1, 99),
        };

        public bool IsFormFound(string surname, int score)
        {
            foreach (var item in forms)
            {
                if(item.Surname == surname)
                {
                    if(item.FirstScore == score || item.SecondScore == score || item.ThirdScore == score)
                    {
                        return true;
                    }
                }    
            }
            return false;
        }
        public (string, string, string, float, int) GetDate(string surname, int year, int score)
        {
            foreach (var item in forms)
            {
                if (item.Surname == surname)
                {
                    if (item.FirstScore == score || item.SecondScore == score || item.ThirdScore == score)
                    {
                        return (item.Surname,
                            item.Nationality,
                            item.Surname + year.ToString(),
                            (float)(item.FirstScore + item.SecondScore + item.ThirdScore) / 3,
                            DateTime.Now.Year - year);
                    }
                }
            }
            return ("", "", "", 0, 0);
        }
    }
}
