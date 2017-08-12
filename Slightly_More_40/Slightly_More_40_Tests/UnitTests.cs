using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slightly_More_40;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Slightly_More_40_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor38()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("38");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForb()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("b");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative12()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-12");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor12()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("12");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For36()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetRemainder(36);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns16For56()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.GetRemainder(56);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsSlightlyMore(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsSlightlyMore(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsSlightlyMore(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor4()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsSlightlyMore(4);

            Assert.AreEqual(expected, actual);
        }
    }
}
