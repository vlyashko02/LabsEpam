using lab8.BL;

namespace lab8.CMD
{
    class Program
    {
        static void Main()
        {
            double[,] array1 = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,] array2 = new double[3, 3] { { 6, 7, -2 }, { 1, 7, 0 }, { 3, 8, -8 } };

            Matrix matrix1 = new Matrix(array1);
            Matrix matrix2 = new Matrix(array2);

            Output(matrix1 + matrix2);
            System.Console.WriteLine();
            Output(matrix1 * matrix2);
            System.Console.WriteLine();
            Output(matrix2 - matrix1);
        }
        static void Output(Matrix matrix)
        {
            for (int i = 0; i < matrix.GetArrayMatrix().GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetArrayMatrix().GetLength(1); j++)
                {
                    System.Console.Write($"{matrix.GetArrayMatrix()[i, j]} ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
