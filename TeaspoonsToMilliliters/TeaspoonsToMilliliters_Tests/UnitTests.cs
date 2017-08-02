using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaspoonsToMilliliters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeaspoonsToMilliliters_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForOregon()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Oregon");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor98point7()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("98.7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative13point249()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-13.249");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor13point249()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("13.249");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns118point29For24()
        {
            var expected = 118.29;

            var utility = new Utility();
            var actual = utility.GetMilliliters(24);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns372point61For75point5974()
        {
            var expected = 372.61;

            var utility = new Utility();
            var actual = utility.GetMilliliters(75.5974);

            Assert.AreEqual(expected, actual);
        }
    }
}
