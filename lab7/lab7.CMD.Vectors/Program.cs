using lab7.BL;

namespace lab7.CMD.Vectors
{
    class Program
    {
        static void Main()
        {
            Vector3 vector1 = new Vector3(1, 2, 3);
            Vector3 vector2 = new Vector3(6, 7, 8);

            System.Console.WriteLine(vector1 + vector2);
            System.Console.WriteLine(vector1 * 5);
            System.Console.WriteLine(Vector3.VectorProduct(vector1, vector2));
        }
    }
}
