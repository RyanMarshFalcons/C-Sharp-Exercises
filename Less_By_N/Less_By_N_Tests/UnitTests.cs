using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_N;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Less_By_N_Tests
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
            var actual = utility.GetDiffs(new int[] { 9, 4, 1, 8, 4 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For2329304230()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.IsLessByN(new int[] { 23, 29, 30, 42 }, 30 );

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3For1319252818()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.IsLessByN(new int[] { 13, 19, 25, 28 }, 18);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1For3035475850()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.IsLessByN(new int[] { 30, 35, 47, 58 }, 50);

            Assert.AreEqual(expected, actual);
        }
    }
}
