using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KilogramsToPounds;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KilogramsToPounds_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForIdaho()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Idaho");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor48point123()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("48.123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative27point258()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-27.258");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor27point258()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("27.258");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns11point02For5()
        {
            var expected = 11.02;

            var utility = new Utility();
            var actual = utility.GetPounds(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns125point49For56point922()
        {
            var expected = 125.49;

            var utility = new Utility();
            var actual = utility.GetPounds(56.922);

            Assert.AreEqual(expected, actual);
        }
    }
}
