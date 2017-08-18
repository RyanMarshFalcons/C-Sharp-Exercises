using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_10_50;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Max_10_50_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor36()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("36");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForg()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("g");

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
        public void ReturnsTrueFor35()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(35);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor50()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(50);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor9()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor51()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(51);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFoNegative35()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasPower(-35);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor4242()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(42, 42);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor4243()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEqual(42, 43);

            Assert.AreEqual(expected, actual);
        }
    }
}
