using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Letter_Sorter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Letter_Sorter_Testing
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void returnsTrueForComma()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfChar(",");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsFalseForFF()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfChar("FF");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsFalseForSeimColon()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLetter(';');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrueForQ()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLetter('Q');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsFalseForp()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("p");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsacegi()
        {
            var expectedList = new List<char>() { 'a', 'c', 'e', 'g', 'i'};


            var utility = new Utility();
            var actualList = new List<char>() { 'e', 'i', 'c', 'a', 'g' };
            actualList = utility.SortTheLetters(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void returnsBDQaeiou()
        {
            var expectedList = new List<char>() { 'B', 'D', 'Q', 'a', 'e', 'i', 'o', 'u' };


            var utility = new Utility();
            var actualList = new List<char>() { 'o', 'D', 'e', 'B', 'a', 'i', 'u', 'Q' };
            actualList = utility.SortTheLetters(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}
