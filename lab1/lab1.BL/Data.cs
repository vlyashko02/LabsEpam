namespace lab1.BL
{
    /// <summary>
    /// Данные, состоящие из двух координат.
    /// </summary>
    public class Data
    {
        public readonly string X;
        public readonly string Y;
        public readonly string formatted;

        public Data(string data)
        {
            string[] format = data.Split(',');

            X = Format(format[0]);
            Y = Format(format[1]);
            formatted = $"X:{X} Y:{Y}";
        }

        private static string Format(string formatXY)
        {
            string line = "";
            foreach (var item in formatXY)
            {
                if (item != '.')
                    line += item;
                else
                    line += ',';
            }

            return line;
        }
    }
}
