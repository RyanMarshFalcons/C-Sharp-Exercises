using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slightly_More_10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Slightly_More_10_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor19()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("19");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForc()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("c");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative8()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-8");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor8()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("8");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For3()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetRemainder(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3For13()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetRemainder(13);

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
