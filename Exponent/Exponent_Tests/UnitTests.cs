using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exponent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exponent_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor18()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("18");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForP()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("P");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor3()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8For2And3()
        {
            var expected = 8;

            var utility = new Utility();
            var actual = utility.GetProduct(2, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns625For5And4()
        {
            var expected = 625;

            var utility = new Utility();
            var actual = utility.GetProduct(5, 4);

            Assert.AreEqual(expected, actual);
        }
    }
}
