using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slightly_More_50;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Slightly_More_50_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor42()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("42");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFors()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("s");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative22()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-22");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor22()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("22");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For45()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetRemainder(45);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5For55()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetRemainder(55);

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
