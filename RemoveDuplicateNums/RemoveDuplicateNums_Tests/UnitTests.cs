using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveDuplicateNums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemoveDuplicateNums_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseforJ()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor12()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("12");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForp()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("p");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns12345()
        {
            var expected = new List<int>() { 1, 2, 3, 4, 5 };

            var utility = new Utility();
            var actual = utility.RemoveDuplicates(new List<int>() { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns738194()
        {
            var expected = new List<int>() { 7, 3, 8, 1, 9, 4};

            var utility = new Utility();
            var actual = utility.RemoveDuplicates(new List<int>() { 7, 3, 7, 3, 8, 8, 7, 3, 8, 1, 9, 8, 7, 4, 4 });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
