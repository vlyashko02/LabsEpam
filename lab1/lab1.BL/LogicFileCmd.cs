using System;
using System.Collections.Generic;
using lab1.BL;

namespace lab1.CMD
{
    public class LogicFileCmd : BaseLogic
    {
        public LogicFileCmd()
        {
            GetDate(ModeForData.File);
        }
        public override void ShowFormattedData(List<Data> coorList)
        {
            foreach (var item in coorList)
            {
                Console.WriteLine(item.formatted);
            }
        }
        protected override void Exception()
        {
            Console.WriteLine("Ошибка при получении пути.");
        }
    }
}