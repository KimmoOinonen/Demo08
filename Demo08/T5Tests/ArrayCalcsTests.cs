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
            double[] array = new double[];
            array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 25.6;
            // act
            double actual = array.Sum(array);
            // assert

        }

        [TestMethod()]
        public void AverageTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MinimumTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MaximumTest()
        {
            Assert.Fail();
        }
    }
}