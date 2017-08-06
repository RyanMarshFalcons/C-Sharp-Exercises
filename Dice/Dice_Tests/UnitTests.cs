using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dice_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForfly()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("fly");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor17()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("17");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor3()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns21For123456()
        {
            var expected = 21;

            var utility = new Utility();
            var actual = utility.GetSum(new List<int>() { 1, 2, 3, 4, 5, 6 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns50For3351245223261236()
        {
            var expected = 50;

            var utility = new Utility();
            var actual = utility.GetSum(new List<int>() { 3, 3, 5, 1, 2, 4, 5, 2, 2, 3, 2, 6, 1, 2, 3, 6 });

            Assert.AreEqual(expected, actual);
        }
    }
}
