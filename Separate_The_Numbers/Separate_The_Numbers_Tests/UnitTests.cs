using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Separate_The_Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Separate_The_Numbers_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThreeIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TenIsNotLargeEnough()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLargeEnough("10");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ElevenIsNotLargeEnough()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLargeEnough("11");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwelveIsLargeEnough()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLargeEnough("12");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThirteenIsLargeEnough()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLargeEnough("13");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesAllLeadingZeroes()
        {
            var expected = "1234";

            var utility = new Utility();
            var actual = utility.RemoveLeadingZeroes("00001234");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheFirstTwoNumbersOf12345Are1And2()
        {
            var expected = new List<int>() { 1, 2 };

            var utility = new Utility();
            var actual = utility.GetFirstTwoNumbers("12345");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheFirstTwoNumbersOf91011Are9And10()
        {
            var expected = new List<int>() { 9, 10 };

            var utility = new Utility();
            var actual = utility.GetFirstTwoNumbers("91011");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UnableToGetSequentialNumbers()
        {
            var expected = new List<int>() { -1, 0 };

            var utility = new Utility();
            var actual = utility.GetFirstTwoNumbers("6874");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesTheFirstTwoNumbersOf12345()
        {
            var expected = "345";

            var utility = new Utility();
            var actual = utility.RemoveFirstTwoNumbersFromString("12345", new List<int>() { 1, 2 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesTheFirstTwoNumbersOf91011()
        {
            var expected = "11";

            var utility = new Utility();
            var actual = utility.RemoveFirstTwoNumbersFromString("91011", new List<int>() { 9, 10 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Adds11And12ToTheList()
        {
            var expected = new List<int>() { 9, 10, 11, 12 };

            var utility = new Utility();
            var actual = utility.GetRestOfNumbers("1112", new List<int>() { 9, 10 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Adds5678And9ToTheList()
        {
            var expected = new List<int>() { 3, 4, 5, 6, 7, 8, 9 };

            var utility = new Utility();
            var actual = utility.GetRestOfNumbers("56789", new List<int>() { 3, 4 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsNegative1ToTheListIfNotMatch()
        {
            var expected = new List<int>() { 9, 10, 11, -1 };

            var utility = new Utility();
            var actual = utility.GetRestOfNumbers("1113", new List<int>() { 9, 10 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsCommasToListWhenBecomesString()
        {
            var expected = "8, 9, 10, 11";

            var utility = new Utility();
            var actual = utility.ConvertListToString(new List<int>() { 8, 9, 10, 11 });

            Assert.AreEqual(expected, actual);
        }
    }
}
