using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_10_20;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Max_10_20_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor35()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("35");

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
        public void ReturnsTrueFor10()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor15()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor20()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(20);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor5()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor25()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(25);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFoNegative15()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(-15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1212()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(12, 12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor1213()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(12, 13);

            Assert.AreEqual(expected, actual);
        }
    }
}
