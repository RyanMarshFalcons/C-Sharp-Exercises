using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Less_By_10_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor37()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("37");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFory()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns21For576()
        {
            var expected = new int[] { 2, 1 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 5, 7, 6 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns75For942()
        {
            var expected = new int[] { 7, 5 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 9, 4, 2 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For1012()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.IsLessBy10(new int[] { 10, 12 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1For134()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.IsLessBy10(new int[] { 13, 4 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For89()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.IsLessBy10(new int[] { 8, 9 });

            Assert.AreEqual(expected, actual);
        }
    }
}
