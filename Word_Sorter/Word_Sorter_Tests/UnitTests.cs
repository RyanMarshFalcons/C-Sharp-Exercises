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
        public void returnsTrueForCant()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfWord("can't");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsFalseForSuperMan()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfWord("Super Man");

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
        public void returnsFalseForz()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("z");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void returnsAppleBananaCarrotDoughnutEgg()
        {
            var expectedList = new List<string>() { "apple", "banana", "carrot", "doughnut", "egg" };


            var utility = new Utility();
            var actualList = new List<string>() { "doughnut", "banana", "egg", "apple", "carrot" };
            actualList = utility.SortTheWords(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void returnsCantDontMustntShouldntWontWouldnt()
        {
            var expectedList = new List<string>() { "can't", "don't", "mustn't", "shouldn't", "won't", "wouldn't" };

            var utility = new Utility();
            var actualList = new List<string>() { "won't", "don't", "wouldn't", "can't", "mustn't", "shouldn't" };
            actualList = utility.SortTheWords(actualList);

            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}
