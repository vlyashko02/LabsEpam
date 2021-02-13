using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab7.BL.Tests
{
    [TestClass()]
    public class PolinomialTests
    {
        [TestMethod()]
        public void Div()
        {
            Polinomial polinomial1 = new Polinomial(new double[] { 5, 3, 0, 1, 7, 9 });
            Polinomial polinomial2 = new Polinomial(new double[] { 1, 0, 5, -3, -3, -29 });

            Polinomial expected = new Polinomial(new double[] { 5 });
            Polinomial actual = (polinomial1 / polinomial2).Item1;

            Assert.IsTrue(actual.CompareTo(expected));
        }
        [TestMethod]
        public void Sum()
        {
            Polinomial polinomial1 = new Polinomial(new double[] { 5, 3, 0,  1,  7,  9 });
            Polinomial polinomial2 = new Polinomial(new double[] { 1, 0, 5, -3, -3, -29 });

            Polinomial expected = new Polinomial(new double[] { 6, 3, 5, -2, 4, -20 });
            Polinomial actual = polinomial1 + polinomial2;

            Assert.IsTrue(actual.CompareTo(expected));
        }
        [TestMethod]
        public void Sub()
        {
            Polinomial polinomial1 = new Polinomial(new double[] { 5, 3, 0, 1, 7, 9 });
            Polinomial polinomial2 = new Polinomial(new double[] { 1, 0, 5, -3, -3, -29 });

            Polinomial expected = new Polinomial(new double[] { 4, 3, -5, 4, 10, 38 });
            Polinomial actual = polinomial1 - polinomial2;

            Assert.IsTrue(actual.CompareTo(expected));
        }
        [TestMethod()]
        public void MulNumber()
        {
            Polinomial polinomial1 = new Polinomial(new double[] { 5, 3, 0, 1, 7, 9 });
            double k = 2;

            Polinomial expected = new Polinomial(new double[] { 10, 6, 0, 2, 14, 18 });
            Polinomial actual = polinomial1 * k;

            Assert.IsTrue(actual.CompareTo(expected));
        }
    }
}