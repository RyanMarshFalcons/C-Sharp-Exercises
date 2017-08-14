using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_20;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Less_By_20_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor51()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("51");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForu()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("u");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns85For6113()
        {
            var expected = new int[] { 8, 5 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 6, 11, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns74For952()
        {
            var expected = new int[] { 7, 4 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 9, 5, 2 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For2023()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.IsLessBy20(new int[] { 20, 23 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1For1324()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.IsLessBy20(new int[] { 13, 24 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For85()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.IsLessBy20(new int[] { 8, 5 });

            Assert.AreEqual(expected, actual);
        }
    }
}
