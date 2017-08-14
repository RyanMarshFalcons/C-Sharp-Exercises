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
        public void Returns85For4712()
        {
            var expected = new int[] { 8, 5 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 4, 7, 12 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns85For941()
        {
            var expected = new int[] { 8, 5 };

            var utility = new Utility();
            var actual = utility.GetDiffs(new int[] { 9, 4, 1});

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2For3042()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.IsLessBy30(new int[] { 30, 42 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1For1374()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.IsLessBy30(new int[] { 13, 74 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0For2829()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.IsLessBy30(new int[] { 28, 29 });

            Assert.AreEqual(expected, actual);
        }
    }
}
