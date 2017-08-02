using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GramsToOunces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GramsToOunces_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForOklahoma()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Oklahoma");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor32point127()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("32.127");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative68point945()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-68.945");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor68point945()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("68.945");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1point48For42()
        {
            var expected = 1.48;

            var utility = new Utility();
            var actual = utility.GetOunces(42);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns31point99For907()
        {
            var expected = 31.99;

            var utility = new Utility();
            var actual = utility.GetOunces(907);

            Assert.AreEqual(expected, actual);
        }
    }
}
