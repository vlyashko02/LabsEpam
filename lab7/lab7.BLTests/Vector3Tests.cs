using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lab7.BL.Tests
{
    [TestClass()]
    public class Vector3Tests
    {
        [TestMethod()]
        public void LengthTest()
        {
            Vector3 vector1 = new Vector3(1, 2, 3);

            double expected = Math.Sqrt(14);
            double actual = vector1.Length();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void VectorProductTest()
        {
            Vector3 vector1 = new Vector3(1, 2, 3);
            Vector3 vector2 = new Vector3(4, 5, 6);

            Vector3 expected = new Vector3(-3, 6, -3);
            Vector3 actual = Vector3.VectorProduct(vector1, vector2);

            Assert.IsTrue(actual.CompareTo(expected));
        }
        [TestMethod()]
        public void MixedProductTest()
        {
            Vector3 vector1 = new Vector3(1, 2, 3);
            Vector3 vector2 = new Vector3(4, 5, 6);
            Vector3 vector3 = new Vector3(7, 8, 9);

            double expected = 0;
            double actual = Vector3.MixedProduct(vector1, vector2, vector3);

            Assert.AreEqual(expected, actual);  
        }
        [TestMethod()]
        public void MulNumber()
        {
            Vector3 vector1 = new Vector3(1, 2, 3);
            double k = 2;

            Vector3 expected = new Vector3(2, 4, 6);
            Vector3 actual = vector1 * k;

            Assert.IsTrue(actual.CompareTo(expected));
        }
        [TestMethod()]
        public void Mul()
        {
            Vector3 vector1 = new Vector3(1, 2, 3);
            Vector3 vector2 = new Vector3(4, 5, 6);

            double expected = 32;
            double actual = vector1 * vector2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Sum()
        {
            Vector3 vector1 = new Vector3(1, 2, 3);
            Vector3 vector2 = new Vector3(4, 5, 6);

            Vector3 expected = new Vector3(5, 7, 9);
            Vector3 actual = vector1 + vector2;

            Assert.IsTrue(actual.CompareTo(expected));
        }
    }
}