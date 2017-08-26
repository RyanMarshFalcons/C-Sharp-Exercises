using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evenly_Spaced;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Evenly_Spaced_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor17()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("17");

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
        public void Return357For735()
        {
            var expected = new int[] { 3, 5, 7 };

            var utility = new Utility();
            var actual = utility.SortNums(new int[] { 7, 3, 5 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Return246For642()
        {
            var expected = new int[] { 2, 4, 6 };

            var utility = new Utility();
            var actual = utility.SortNums(new int[] { 6, 4, 2 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3For710()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetDifference(7, 10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For59()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetDifference(5, 9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor55()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEvenlySpaced(5, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor56()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEvenlySpaced(5, 6);

            Assert.AreEqual(expected, actual);
        }
    }
}
