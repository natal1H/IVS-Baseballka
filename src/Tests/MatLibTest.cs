using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Tests
{
    [TestClass]
    public class MatLibTest
    {
        private const double Accuracy = 1e-7;

        [TestMethod]
        public void ShouldAdd()
        {
            Assert.AreEqual(9, MatLib.add(4, 5));
            Assert.AreEqual(0, MatLib.add(-5, 5));
            Assert.AreEqual(0, MatLib.add(0, 0));
            Assert.AreEqual(100000000, MatLib.add(60000000, 40000000));
            Assert.AreEqual(1, MatLib.add(0.4, 0.6), Accuracy);
            Assert.AreEqual(11.41676488, MatLib.add(4.4893192, 6.92744568), Accuracy);
            Assert.AreEqual(-11.41676488, MatLib.add(-4.4893192, -6.92744568), Accuracy);

            Assert.AreNotEqual(25, MatLib.add(0, -25));
            Assert.AreNotEqual(0, MatLib.add(-5, -5));
            Assert.AreNotEqual(0, MatLib.add(0.00001, 0.00001));
            Assert.AreNotEqual(11.41676488, MatLib.add(4.9993192, 6.99944568), Accuracy);
        }

        [TestMethod]
        public void ShouldSubtract()
        {
            Assert.AreEqual(10, MatLib.subtract(10, 0));
            Assert.AreEqual(-10, MatLib.subtract(0, 10));
            Assert.AreEqual(0, MatLib.subtract(5, 5));
            Assert.AreEqual(0, MatLib.subtract(0, 0));
            Assert.AreEqual(20000000, MatLib.subtract(60000000, 40000000));
            Assert.AreEqual(-0.2, MatLib.subtract(0.4, 0.6), Accuracy);
            Assert.AreEqual(0.2, MatLib.subtract(-0.4, -0.6), Accuracy);
            Assert.AreEqual(-2.43812648, MatLib.subtract(4.4893192, 6.92744568), Accuracy);
            Assert.AreEqual(2.43812648, MatLib.subtract(-4.4893192, -6.92744568), Accuracy);

            Assert.AreNotEqual(0, MatLib.subtract(10, -10));
            Assert.AreNotEqual(0, MatLib.subtract(-10, 10));
            Assert.AreNotEqual(10, MatLib.subtract(-10, 20));
            Assert.AreNotEqual(-50, MatLib.subtract(0, -50.0000357));
        }

        [TestMethod]
        public void ShouldMultiply()
        {
            Assert.AreEqual(1, MatLib.multiply(1, 1));
            Assert.AreEqual(0, MatLib.multiply(1, 0));
            Assert.AreEqual(0, MatLib.multiply(100000, 0));
            Assert.AreEqual(0, MatLib.multiply(0, 100000));
            Assert.AreEqual(4, MatLib.multiply(2, 2));
            Assert.AreEqual(-4, MatLib.multiply(2, -2));
            Assert.AreEqual(6, MatLib.multiply(-2, -3));
            Assert.AreEqual(625, MatLib.multiply(25, 25));
            Assert.AreEqual(1.805375, MatLib.multiply(1.625, 1.111), Accuracy);
            Assert.AreEqual(-1.805375, MatLib.multiply(-1.625, 1.111), Accuracy);
            Assert.AreEqual(-1.805375, MatLib.multiply(1.625, -1.111), Accuracy);
            Assert.AreEqual(1.805375, MatLib.multiply(-1.625, -1.111), Accuracy);
            Assert.AreEqual(0.0009, MatLib.multiply(9, 0.0001), Accuracy);


            Assert.AreNotEqual(100, MatLib.multiply(10, -10));
            Assert.AreNotEqual(0.13, MatLib.multiply(0.4, 0.3));
            Assert.AreNotEqual(-10000, MatLib.multiply(-100, -100));
            Assert.AreNotEqual(-0.002, MatLib.multiply(0.0002, -0.1), Accuracy);
        }

        [TestMethod]
        public void ShouldDivide()
        {
            try
            {
                MatLib.divide(1, 0);
                Assert.Fail("ERROR, delenie nulou.");
            }
            catch
            {
            }

            try
            {
                MatLib.divide(-549.41268, 0);
                Assert.Fail("ERROR, delenie nulou.");
            }
            catch
            {
            }

            Assert.AreEqual(1, MatLib.divide(1, 1));
            Assert.AreEqual(100, MatLib.divide(100, 1));
            Assert.AreEqual(0.01, MatLib.divide(1, 100), Accuracy);
            Assert.AreEqual(5, MatLib.divide(50, 10));
            Assert.AreEqual(-5, MatLib.divide(50, -10));
            Assert.AreEqual(5, MatLib.divide(-50, -10));
            Assert.AreEqual(0, MatLib.divide(0, 10));
            Assert.AreEqual(10, MatLib.divide(5, 0.5), Accuracy);
            Assert.AreEqual(100, MatLib.divide(1, 0.01), Accuracy);
            Assert.AreEqual(0.6480482716, MatLib.divide(4.4893192, 6.92744568), Accuracy);

            Assert.AreNotEqual(0.6, MatLib.divide(4.4893192, 6.92744568), Accuracy);
            Assert.AreNotEqual(0.4, MatLib.divide(0.1601, 4));
            Assert.AreNotEqual(10, MatLib.divide(0, 10));
        }

        [TestMethod]
        public void ShouldFactorial()
        {

        }
    }
}
