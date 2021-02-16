using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab8.BL.Tests
{
    [TestClass()]
    public class MatrixTests
    {
        [TestMethod]
        public void Sum()
        {
            double[,] array1 = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,] array2 = new double[3, 3] { { 6, 7, -2 }, { 1, 7, 0 }, { 3, 8, -8 } };

            Matrix expected = new Matrix(new double[3, 3] { { 7, 9, 1 }, { 5, 12, 6 }, { 10, 16, 1 } });
            Matrix actual = new Matrix(array1) + new Matrix(array2);

            Assert.IsTrue(actual.EqualTo(expected));
        }
        [TestMethod]
        public void Sub()
        {
            double[,] array1 = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,] array2 = new double[3, 3] { { 6, 7, -2 }, { 1, 7, 0 }, { 3, 8, -8 } };

            Matrix expected = new Matrix(new double[3, 3] { { -5, -5, 5 }, { 3, -2, 6 }, { 4, 0, 17 } });
            Matrix actual = new Matrix(array1) - new Matrix(array2);

            Assert.IsTrue(actual.EqualTo(expected));
        }
        [TestMethod]
        public void Mul()
        {
            double[,] array1 = new double[3, 3] { { 1, 2, 1 }, { 9, 8, 9 }, { 7, 3, 4 } };
            double[,] array2 = new double[3, 3] { { 7, 9, 8 }, { 11, -3, 6 }, { 5, -1, -2 } };

            Matrix expected = new Matrix(new double[3, 3] { { 34, 2, 18 }, { 196, 48, 102 }, { 102, 50, 66 } });
            Matrix actual = new Matrix(array1) * new Matrix(array2);

            Assert.IsTrue(actual.EqualTo(expected));
        }
    }
}