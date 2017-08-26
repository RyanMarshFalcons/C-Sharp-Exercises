using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lone_Sum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lone_Sum_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor16()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("16");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForf()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("f");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor335()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfMatch(3, 3, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor345()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfMatch(3, 4, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns18For567()
        {
            var expected = 18;

            var utility = new Utility();
            var actual = utility.GetSum(new int[] { 5, 6, 7 }, new bool[] { false, false, false });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5For577()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetSum(new int[] { 5, 7, 7 }, new bool[] { false, true, true });

            Assert.AreEqual(expected, actual);
        }
    }
}
