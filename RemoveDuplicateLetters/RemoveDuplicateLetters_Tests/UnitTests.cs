using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveDuplicateLetters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemoveDuplicateLetters_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForPeriod()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfChar(".");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForGG()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfChar("GG");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForComma()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLetter(',');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForM()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLetter('M');

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
        public void ReturnsFalseFort()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("t");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnsabcde()
        {
            var expected = new List<char>() { 'a', 'b', 'c', 'd', 'e' };

            var utility = new Utility();
            var actual = utility.RemoveDuplicates(new List<char>() { 'a', 'a', 'b', 'a', 'c', 'b', 'd', 'd', 'e', 'c' });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returnscrvdts()
        {
            var expected = new List<char>() { 'c', 'r', 'v', 'd', 't', 's' };

            var utility = new Utility();
            var actual = utility.RemoveDuplicates(new List<char>() { 'c', 'c', 'c', 'r', 'r', 'v', 'v', 'c', 'v', 'd', 't', 'd', 's', 't' });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
