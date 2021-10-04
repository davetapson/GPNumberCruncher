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
            int expected = 1;

            // act

            // assert
            Assert.AreEqual(expected, 2);
        }

        [TestMethod]
        public void CrunchNumbers_Above_152_Test()
        {
            // assemble
            int expected = 1;

            // act

            // assert
            Assert.AreEqual(expected, 2);
        }
    }
}
