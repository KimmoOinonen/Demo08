using Microsoft.VisualStudio.TestTools.UnitTesting;
using T5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            // arrange
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 25.6;
            // act
            double actual = ArrayCalcs.Sum(array);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            // arrange
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 3.66;
            // act
            double actual = ArrayCalcs.Average(array);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinimumTest()
        {
            // arrange
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = -4.5;
            // act
            double actual = ArrayCalcs.Minimum(array);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaximumTest()
        {
            // arrange
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 12.0;
            // act
            double actual = ArrayCalcs.Maximum(array);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}