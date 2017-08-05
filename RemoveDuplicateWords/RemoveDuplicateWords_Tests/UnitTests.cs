using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveDuplicateWords;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemoveDuplicateWords_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForshouldnt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfWord("shouldn't");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFornumber3()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfWord("number3");

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
        public void ReturnsFalseForx()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("x");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCatDogBird()
        {
            var expected = new List<string>() { "cat", "dog", "bird" };

            var utility = new Utility();
            var actual = utility.RemoveDuplicates(new List<string>() { "cat", "cat", "dog", "bird", "bird" });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsSeeSpotRunFast()
        {
            var expected = new List<string>() { "See", "Spot", "Run", "Fast" };

            var utility = new Utility();
            var actual = utility.RemoveDuplicates(new List<string>() { "See", "Spot", "See", "Run", "Spot", "See", "Fast", "Spot" });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
