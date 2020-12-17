using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace lab1.BL
{
    /// <summary>
    /// Базовый класс логики
    /// </summary>
    public class BaseLogic
    {
        public List<Data> CoorList { get; } = new List<Data>();
        public string Path { get; set; }
        public int CountOfResultLines { get; private set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode">Вариант реализации: file - файл, cmd - консоль</param>
        /// <returns></returns>
        public List<Data> GetDate(ModeForData mode)
        {
            CountOfResultLines = 0;
            if(mode == ModeForData.File)
            {
                if (GetStringPath() == 0)
                {
                    using (StreamReader sr = new StreamReader(Path))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (ValidationData(line))
                            {
                                CoorList.Add(new Data(line));
                                CountOfResultLines++;
                            }
                        }
                    }
                }
            }
            else if(mode == ModeForData.Cmd)
            {
                Console.WriteLine("Write in format: FirstCoordinate,Second Coordinate. Enter 'exit' if you want to end.");
                string userInput = Console.ReadLine();
                while (userInput != "exit")
                {
                    if (ValidationData(userInput))
                        CoorList.Add(new Data(userInput));
                    userInput = Console.ReadLine();
                }
            }
            return CoorList;
        }
        /// <summary>
        /// Получение пути и занесение его в Path
        /// </summary>
        /// <returns>0 - всё отработало верно, 1 - произошла ошибка</returns>
        public int GetStringPath()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Text documents (.txt)| *.txt"
            };
            if(ofd.ShowDialog() == true && !String.IsNullOrEmpty(ofd.FileName))
            {
                Path = ofd.FileName;
                return 0;
            }
            else
            {
                Exception();
                return 1;
            }
        }
        protected virtual void Exception()
        {
            return;
        }
        /// <summary>
        /// Вывод данных
        /// </summary>
        /// <param name="coorList"></param>
        public virtual void ShowFormattedData(List<Data> coorList)
        {
            return;
        }
        /// <summary>
        /// Проверка на полученные данные
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public bool ValidationData(string line)
        {
            string[] lines = line.Split(',');
            try
            {
                float x = Convert.ToSingle(lines[0], new NumberFormatInfo
                {
                    NumberDecimalSeparator = ".",
                });
                x = Convert.ToSingle(lines[1], new NumberFormatInfo
                {
                    NumberDecimalSeparator = ".",
                });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
