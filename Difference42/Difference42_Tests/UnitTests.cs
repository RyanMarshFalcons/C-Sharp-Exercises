using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference42;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Difference42_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor14()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("14");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFors()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("s");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor45()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.GreaterThan42(45);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor35()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.GreaterThan42(35);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns16For50()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.DifferenceTo42(50, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns12For30()
        {
            var expected = 12;

            var utility = new Utility();
            var actual = utility.DifferenceTo42(30, false);

            Assert.AreEqual(expected, actual);
        }
    }
}
