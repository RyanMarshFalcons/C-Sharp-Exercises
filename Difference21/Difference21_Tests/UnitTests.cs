using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference21;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Difference21_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor13()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("13");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForr()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("r");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor25()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.GreaterThan21(25);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor15()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.GreaterThan21(15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns18For30()
        {
            var expected = 18;

            var utility = new Utility();
            var actual = utility.DifferenceTo21(30, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns11For10()
        {
            var expected = 11;

            var utility = new Utility();
            var actual = utility.DifferenceTo21(10, false);

            Assert.AreEqual(expected, actual);
        }
    }
}
