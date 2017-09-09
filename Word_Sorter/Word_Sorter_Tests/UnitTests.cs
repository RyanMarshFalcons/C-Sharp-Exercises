using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word_Sorter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Word_Sorter_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForb()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("b");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Removes3AndExclamationPoints()
        {
            var expected = "Ryan is  times awesome";

            var utility = new Utility();
            var actual = utility.RemoveNumsAndSymbols("Ryan is 3 times awesome!!!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesCommaExclamationPointAtSymbolAndQuestionMark()
        {
            var expected = "Hey there you Where's the party ";

            var utility = new Utility();
            var actual = utility.RemoveNumsAndSymbols("Hey, there you! Where's the party @?");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtractsWordsToList()
        {
            var expected = new List<string>() { "Ryan", "is", "a", "cool", "guy", "Doncha", "know" };
        

            var utility = new Utility();
            var actual = utility.ExtractWords("Ryan is a cool guy!!! Doncha know?");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtractsWordsToListAgain()
        {
            var expected = new List<string>() { "Workin", "to", "what", "a", "way", "to", "make", "a", "livin" };


            var utility = new Utility();
            var actual = utility.ExtractWords("Workin 9 to 5; what a way to make a livin.");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAppleBananaCarrotDoughnutEgg()
        {
            var expectedList = new List<string>() { "apple", "banana", "carrot", "doughnut", "egg" };


            var utility = new Utility();
            var actualList = new List<string>() { "doughnut", "banana", "egg", "apple", "carrot" };
            actualList = utility.SortTheWords(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void ReturnsCantDontMustntShouldntWontWouldnt()
        {
            var expectedList = new List<string>() { "can't", "don't", "mustn't", "shouldn't", "won't", "wouldn't" };

            var utility = new Utility();
            var actualList = new List<string>() { "won't", "don't", "wouldn't", "can't", "mustn't", "shouldn't" };
            actualList = utility.SortTheWords(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}
