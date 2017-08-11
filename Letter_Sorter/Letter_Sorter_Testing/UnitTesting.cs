﻿using System;
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
        public void ReturnsTrueForComma()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfChar(",");

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
        public void ReturnsFalseForSeimColon()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLetter(';');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForQ()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLetter('Q');

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
        public void Returnsacegi()
        {
            var expectedList = new List<char>() { 'a', 'c', 'e', 'g', 'i'};


            var utility = new Utility();
            var actualList = new List<char>() { 'e', 'i', 'c', 'a', 'g' };
            actualList = utility.SortTheLetters(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void ReturnsBDQaeiou()
        {
            var expectedList = new List<char>() { 'B', 'D', 'Q', 'a', 'e', 'i', 'o', 'u' };


            var utility = new Utility();
            var actualList = new List<char>() { 'o', 'D', 'e', 'B', 'a', 'i', 'u', 'Q' };
            actualList = utility.SortTheLetters(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}
