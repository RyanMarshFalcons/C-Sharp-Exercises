using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum_Of_Multiples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sum_Of_Multiples_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void RIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("R");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SevenIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeOneIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ynIsyOrn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void nIsyOrn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void sIsNotyOrn()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("s");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAllMultiplesOf2And3ThatAreLessThan10()
        {
            var expected = new List<int>() { 2, 4, 6, 8, 3, 6, 9 };

            var utility = new Utility();
            var actual = utility.GetAllMultiples(new List<int> { 2, 3}, 10);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAllMultiplesOf58And11ThatAreLessThan30()
        {
            var expected = new List<int>() { 5, 10, 15, 20, 25, 8, 16, 24, 11, 22 };

            var utility = new Utility();
            var actual = utility.GetAllMultiples(new List<int> { 5, 8, 11 }, 30);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCorrectMultiplesOf1LessThan5()
        {
            var expected = new List<int>() { 1, 2, 3, 4 };

            var utility = new Utility();
            var actual = utility.GetMultiples(1, 5);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCorrectMultiplesOf3LessThan10()
        {
            var expected = new List<int>() { 3, 6, 9 };

            var utility = new Utility();
            var actual = utility.GetMultiples(3, 10);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCorrectMultiplesOf5LessThan40()
        {
            var expected = new List<int>() { 5, 10, 15, 20, 25, 30, 35};

            var utility = new Utility();
            var actual = utility.GetMultiples(5, 40);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsNoMultiplesOf7LessThan7()
        {
            var expected = new List<int>();

            var utility = new Utility();
            var actual = utility.GetMultiples(7, 7);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAllUniqueMultiplesOf2And3ThatAreLessThan10()
        {
            var expected = new List<int>() { 2, 4, 6, 8, 3, 9 };

            var utility = new Utility();
            var actual = utility.GetUniqueMultiples(new List<int> { 2, 4, 6, 8, 3, 6, 9 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsAllUniqueMultiplesOf48And13ThatAreLessThan21()
        {
            var expected = new List<int>() { 4, 8, 12, 16, 20, 13 };

            var utility = new Utility();
            var actual = utility.GetUniqueMultiples(new List<int> { 4, 8, 12, 16, 20, 8, 16, 13 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns23AsSumOfMultiplesOf3And5LessThan10()
        {
            var expected = 23;

            var utility = new Utility();
            var actual = utility.CalculateSumOfMultiples(new List<int>() { 3, 5, 6, 9 }, 10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns51AsSumOfMultiplesOf713And17LessThan20()
        {
            var expected = 51;

            var utility = new Utility();
            var actual = utility.CalculateSumOfMultiples(new List<int>() { 7, 13, 14, 17 }, 20);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns30AsSumOfMultiplesOf4And6LessThan15()
        {
            var expected = 30;

            var utility = new Utility();
            var actual = utility.CalculateSumOfMultiples(new List<int>() { 4, 6, 8, 12 }, 15);

            Assert.AreEqual(expected, actual);
        }
    }
}
