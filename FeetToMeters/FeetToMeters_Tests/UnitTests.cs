using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeetToMeters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FeetToMeters_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForOhio()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Ohio");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor86point123()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("86.123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative16point24()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-16.24");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor16point24()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("16.24");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5point49For18()
        {
            var expected = 5.49;

            var utility = new Utility();
            var actual = utility.GetMeters(18);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns24point03For78point8543()
        {
            var expected = 24.03;

            var utility = new Utility();
            var actual = utility.GetMeters(78.8543);

            Assert.AreEqual(expected, actual);
        }
    }
}
