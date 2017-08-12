using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slightly_More_30;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Slightly_More_30_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor19()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("28");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFore()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("e");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative2()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor2()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For28()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetRemainder(28);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3For37()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.GetRemainder(37);

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
