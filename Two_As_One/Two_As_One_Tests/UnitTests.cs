using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Two_As_One;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Two_As_One_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor14()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("14");

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
        public void Returns789For345()
        {
            var expected = new int[] { 7, 8, 9 };

            var utility = new Utility();
            var actual = utility.GetSumsOfNums(new int[] { 3, 4, 5 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns162329For51118()
        {
            var expected = new int[] { 16, 23, 29 };

            var utility = new Utility();
            var actual = utility.GetSumsOfNums(new int[] { 5, 11, 18 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor246And6810()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.TwoAsOnePossible(new int[] { 2, 4, 6 }, new int[] { 6, 8, 10 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor247And6911()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.TwoAsOnePossible(new int[] { 2, 4, 7 }, new int[] { 6, 9, 11 });

            Assert.AreEqual(expected, actual);
        }
    }
}
