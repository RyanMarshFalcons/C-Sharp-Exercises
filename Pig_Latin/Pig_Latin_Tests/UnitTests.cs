using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pig_Latin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pig_Latin_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueIfHasSpaces()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfHasSpaces("hello there");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseIfHasNoSpaces()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfHasSpaces("hellothere");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueIfBeginsWithALetter()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfBeginsWithALetter("abracadabra");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseIfDoesntBeginWithALetter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfBeginsWithALetter("3abracadabra");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertsWordToCharArray()
        {
            var expected = new char[] { 'R', 'y', 'a', 'n' };

            var utility = new Utility();
            var actual = utility.ConvertToCharArray("Ryan");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueIfBeginsWithVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfBeginsWithVowel(new char[] { 'a', 'p', 'p', 'l', 'e' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseIfBeginsWithConsonant()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfBeginsWithVowel(new char[] { 'p', 'i', 'n', 'e', 'a', 'p', 'p', 'l', 'e' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueIfVowel()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('e');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseIfNotVowel()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfVowel('t');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsIdahoyay()
        {
            var expected = "Idahoyay";

            var utility = new Utility();
            var actual = utility.AddYayToTheEnd(new char[] { 'I', 'd', 'a', 'h', 'o' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsEersch()
        {
            var expected = "eersch";

            var utility = new Utility();
            var actual = utility.MoveConsonantsToTheEnd(new char[] { 'c', 'h', 'e', 'e', 'r', 's' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.ConsonantCounter(new char[] { 's', 'p', 'l', 'a', 't' });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsIckay()
        {
            var expected = "ickay";

            var utility = new Utility();
            var actual = utility.AddAyToTheEnd("ick");

            Assert.AreEqual(expected, actual);
        }
    }
}
