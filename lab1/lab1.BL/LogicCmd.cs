using System;
using System.Collections.Generic;

namespace lab1.BL
{
    public class LogicCmd : BaseLogic
    {
        public LogicCmd()
        {
            GetDate(ModeForData.Cmd);
        }
        public override void ShowFormattedData(List<Data> coorList)
        {
            foreach (var item in CoorList)
            {
                Console.WriteLine(item.formatted);
            }
        }
    }
}
