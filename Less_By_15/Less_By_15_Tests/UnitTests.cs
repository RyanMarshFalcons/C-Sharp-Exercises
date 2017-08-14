using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_15;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Less_By_15_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor45()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("45");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForw()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("w");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns51For387()
        {
            var expected = new int[] { 5, 1 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 3, 8, 7 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns65For943()
        {
            var expected = new int[] { 6, 5 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 9, 4, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For1518()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.IsLessBy15(new int[] { 15, 18 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1For154()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.IsLessBy15(new int[] { 15, 4 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For32()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.IsLessBy15(new int[] { 3, 2 });

            Assert.AreEqual(expected, actual);
        }
    }
}
