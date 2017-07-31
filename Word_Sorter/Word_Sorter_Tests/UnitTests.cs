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
        public void ReturnsTrueForCant()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfWord("can't");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForSuperMan()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfWord("Super Man");

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
        public void ReturnsFalseForz()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("z");

            Assert.AreEqual(expected, actual);
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
