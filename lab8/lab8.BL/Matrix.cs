namespace lab8.BL
{
    public class Matrix
    {
        private readonly double[,] array;

        public Matrix(double[,] array)
        {
            this.array = array;
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.array.GetLength(0) == matrix2.array.GetLength(0) &&
                matrix1.array.GetLength(1) == matrix2.array.GetLength(1))
            {
                double[,] matrix = new double[matrix1.array.GetLength(0), matrix1.array.GetLength(1)];
                for (int i = 0; i < matrix1.array.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.array.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix1.array[i, j] + matrix2.array[i, j];
                    }
                }
                return new Matrix(matrix);
            }
            else
                throw new System.Exception("Размерности матриц не равны.");
        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.array.GetLength(0) == matrix2.array.GetLength(0) &&
                matrix1.array.GetLength(1) == matrix2.array.GetLength(1))
            {
                double[,] matrix = new double[matrix1.array.GetLength(0), matrix1.array.GetLength(1)];
                for (int i = 0; i < matrix1.array.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.array.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix1.array[i, j] - matrix2.array[i, j];
                    }
                }
                return new Matrix(matrix);
            }
            else
                throw new System.Exception("Размерности матриц не равны.");
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.array.GetLength(1) == matrix2.array.GetLength(0))
            {
                double[,] matrix = new double[matrix1.array.GetLength(0), matrix2.array.GetLength(1)];

                for (int i = 0; i < matrix1.array.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.array.GetLength(1); j++)
                    {
                        matrix[i, j] = 0;
                        for (int k = 0; k < matrix1.array.GetLength(0); k++)
                        {
                            matrix[i, j] += matrix1.array[i, k] * matrix2.array[k, j];
                        }
                    }
                }
                return new Matrix(matrix);
            }
            else
                throw new System.Exception("Количество столбцов не равно количеству строк.");
        }
        public bool EqualTo(Matrix matrix)
        {
            if (matrix.array.GetLength(0) == array.GetLength(0) &&
                matrix.array.GetLength(1) == array.GetLength(1))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] != matrix.array[i, j])
                            return false;
                    }
                }
                return true;
            }
            else
                return false;
        }
        public double[,] GetArrayMatrix() => array;
    }
}
