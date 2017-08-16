using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using End_Up;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace End_Up_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForit()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("it");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForits()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("its");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsABCforabc()
        {
            var expected = "ABC";

            var utility = new Utility();
            var actual = utility.MakeEndUpperCase("abc");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsabracadaBRAForabracadabra()
        {
            var expected = "abracadaBRA";

            var utility = new Utility();
            var actual = utility.MakeEndUpperCase("abracadabra");

            Assert.AreEqual(expected, actual);
        }
    }
}
