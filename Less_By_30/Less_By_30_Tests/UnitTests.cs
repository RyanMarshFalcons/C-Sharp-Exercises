using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_30;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Less_By_30_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor65()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("65");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForm()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("m");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8543For471289()
        {
            var expected = new int[] { 8, 5, 4, 3 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 4, 7, 12, 8, 9 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8551For94184()
        {
            var expected = new int[] { 8, 5, 5, 1 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 9, 4, 1, 8, 4});

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For23293042()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.IsLessBy30(new int[] { 23, 29, 30, 42 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1For13192528()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.IsLessBy30(new int[] { 13, 19, 25, 28 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For30354758()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.IsLessBy30(new int[] { 30, 35, 47, 58 });

            Assert.AreEqual(expected, actual);
        }
    }
}
