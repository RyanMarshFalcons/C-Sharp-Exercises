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
        public void Returns3122For4712810()
        {
            var expected = new int[] { 3, 1, 2, 2 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 4, 7, 12, 8, 10 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3221For94186()
        {
            var expected = new int[] { 3, 2, 2, 1 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 9, 4, 1, 8, 6 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5555()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEvenlySpaced(new int[] { 5, 5, 5, 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor5556()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEvenlySpaced(new int[] { 5, 5, 5, 6 });

            Assert.AreEqual(expected, actual);
        }
    }
}
