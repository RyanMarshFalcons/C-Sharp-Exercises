using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slightly_More_20;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Slightly_More_20_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor21()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("21");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFord()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("d");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative6()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-6");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor6()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("6");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For7()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetRemainder(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3For23()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetRemainder(23);

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
