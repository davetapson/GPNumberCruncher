using GPNumberCruncher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPNumberCruncher_Tests
{
    [TestClass]
    public class NumberHandler_Tests
    {
        [TestMethod]
        public void CrunchNumbers_Below_152_Test()
        {
            // assemble
            int savedNumber = 1;
            int userNumber = 2;
            int expected = savedNumber + userNumber;

            // act
            int actual = NumberHandler.CrunchNumbers(savedNumber, userNumber);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CrunchNumbers_Above_152_Test()
        {
            // assemble
            int savedNumber = 152;
            int userNumber = 2;
            int expected = savedNumber + userNumber - 152;

            // act
            int actual = NumberHandler.CrunchNumbers(savedNumber, userNumber);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
