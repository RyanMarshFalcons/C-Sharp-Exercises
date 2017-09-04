using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remove_Duplicates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Remove_Duplicates_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsToShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForP()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsToShort("P");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForD()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRemoveDuplicateLettersForA()
        {
            var expected = RemoveDuplicate.letters;

            var utility = new Utility();
            var actual = utility.ConvertLetterToRemoveDupicate("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRemoveDuplicateNumbersForB()
        {
            var expected = RemoveDuplicate.numbers;

            var utility = new Utility();
            var actual = utility.ConvertLetterToRemoveDupicate("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRemoveDuplicateSymbolsForC()
        {
            var expected = RemoveDuplicate.symbols;

            var utility = new Utility();
            var actual = utility.ConvertLetterToRemoveDupicate("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRemovesOnlyDuplicateasandbs()
        {
            var expected = "a111***b222&&&1*2&";

            var utility = new Utility();
            var actual = utility.RemoveDuplicateLetters("aaa111***bbb222&&&a1*b2&");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRemovesOnlyDuplicate1sand2s()
        {
            var expected = "aaa1***bbb2&&&a*b&";

            var utility = new Utility();
            var actual = utility.RemoveDuplicateNumbers("aaa1***bbb2&&&a*b&");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRemovesOnlyDuplicateStarssandAmpersands()
        {
            var expected = "aaa111*bbb222&a1b2";

            var utility = new Utility();
            var actual = utility.RemoveDuplicateSymbols("aaa111*bbb222&a1b2");

            Assert.AreEqual(expected, actual);
        }
    }
}
