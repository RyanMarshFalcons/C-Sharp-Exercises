using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Account;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank_Account_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForlog()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("log");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor19point79()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("19.79");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative5()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("5");

            Assert.AreEqual(expected, actual);
        }
    }
}
