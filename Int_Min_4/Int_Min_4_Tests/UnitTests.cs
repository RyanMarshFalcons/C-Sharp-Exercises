using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Min_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Int_Min_4_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor31()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("31");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFork()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("k");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns9For79105()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetMin(7, 9, 10, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNegative8For12Negative81Negative2()
        {
            var expected = -8;

            var utility = new Utility();
            var actual = utility.GetMin(12, -8, 1, -2);

            Assert.AreEqual(expected, actual);
        }
    }
}
