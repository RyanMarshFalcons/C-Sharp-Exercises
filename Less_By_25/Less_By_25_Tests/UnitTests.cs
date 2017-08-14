using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_25;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Less_By_25_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor21()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("21");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFors()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("s");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns21For345()
        {
            var expected = new int[] { 2, 1 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 3, 4, 5 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns72For9411()
        {
            var expected = new int[] { 7, 2 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 9, 4, 11 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For2532()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.IsLessBy25(new int[] { 25, 32 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1For1344()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.IsLessBy25(new int[] { 13, 44 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For2123()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.IsLessBy25(new int[] { 21, 23 });

            Assert.AreEqual(expected, actual);
        }
    }
}
