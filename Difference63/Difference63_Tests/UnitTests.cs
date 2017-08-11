using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference63;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Difference63_Tests
{

    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor15()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("15");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("t");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor65()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.GreaterThan63(65);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor55()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.GreaterThan63(55);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns14For70()
        {
            var expected = 14;

            var utility = new Utility();
            var actual = utility.DifferenceTo63(70, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns13For50()
        {
            var expected = 13;

            var utility = new Utility();
            var actual = utility.DifferenceTo63(50, false);

            Assert.AreEqual(expected, actual);
        }
    }
}

