using lab7.BL;

namespace lab7.CMD.Polinomials
{
    class Program
    {
        static void Main()
        {
            Polinomial polinomial1 = new Polinomial(new double[] { 1, 2, 1, 0 });
            Polinomial polinomial2 = new Polinomial(new double[] { 3, 1, 1, 7 });

            Polinomial polinomial = polinomial1 - polinomial2;
            System.Console.WriteLine(polinomial.ToString());

            Polinomial polinomial3 = polinomial2 * 3;
            System.Console.WriteLine(polinomial3.ToString());

            (Polinomial, Polinomial) t = polinomial2 / polinomial1;

            System.Console.WriteLine($"{t.Item1.ToString()} with {t.Item2.ToString()}");
        }
    }
}
