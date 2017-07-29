using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Squared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Squared_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("17");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNotInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("p");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns64ForNegative8()
        {
            var expected = 64;

            var utilty = new Utility();
            var actual = utilty.GetNumberSquared(-8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns25For5()
        {
            var expected = 25;

            var utilty = new Utility();
            var actual = utilty.GetNumberSquared(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns81For9()
        {
            var expected = 81;

            var utilty = new Utility();
            var actual = utilty.GetNumberSquared(9);

            Assert.AreEqual(expected, actual);
        }
    }
}
