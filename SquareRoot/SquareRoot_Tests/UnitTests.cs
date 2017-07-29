using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareRoot;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquareRoot_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForDouble()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("4.73");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNotDouble()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("quail");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative(-13.75);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative(13.75);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns100For10()
        {
            var expected = 10;

            var utility = new Utility();
            var actual = utility.GetSquareRoot(100);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3point4For11point56()
        {
            var expected = 3.4;

            var utility = new Utility();
            var actual = utility.GetSquareRoot(11.56);

            Assert.AreEqual(expected, actual);
        }
    }
}
