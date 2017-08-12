using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_As_One;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Three_As_One_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor12()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("12");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForp()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("p");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns12131415For3456()
        {
            var expected = new int[] { 12, 13, 14, 15 };

            var utility = new Utility();
            var actual = utility.GetSumsOfNums(new int[] { 3, 4, 5, 6 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns33384551For5111822()
        {
            var expected = new int[] { 34, 38, 45, 51 };

            var utility = new Utility();
            var actual = utility.GetSumsOfNums(new int[] { 5, 11, 18, 22 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor246And6810()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.ThreeAsOnePossible(new int[] { 2, 4, 6, 12 }, new int[] { 12, 18, 20, 22});

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor247And6911()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.ThreeAsOnePossible(new int[] { 2, 4, 6, 13 }, new int[] { 12, 19, 21, 23 });

            Assert.AreEqual(expected, actual);
        }
    }
}
