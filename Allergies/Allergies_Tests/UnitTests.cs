using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allergies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Allergies_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void NineteenIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("19");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeOneIsANegativeNumber()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotANegativeNumber()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoHundredFiftySixIsMoreThanTwoHundredFiftyFive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfMoreThan255("256");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoHundredFiftyFiveIsNotMoreThanTwoHundredFiftyFive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfMoreThan255("255");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScoreOfZeroAllergicToNothing()
        {
            var expected = new List<string>();

            var utility = new Utility();
            var actual = utility.DetermineListOfAllergies(0);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScoreOfOneAllergicToEggs()
        {
            var expected = new List<string>() { "eggs" };

            var utility = new Utility();
            var actual = utility.DetermineListOfAllergies(1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScoreOfFiveAllergicToShellfishAndEggs()
        {
            var expected = new List<string>() { "shellfish", "eggs" };

            var utility = new Utility();
            var actual = utility.DetermineListOfAllergies(5);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScoreOfEightAllergicToStrawberries()
        {
            var expected = new List<string>() { "strawberries" };

            var utility = new Utility();
            var actual = utility.DetermineListOfAllergies(8);

            CollectionAssert.AreEqual(expected, actual);
        }

        public void ScoreOfFiftyAllergicToChocolateTomatoesAndPeanuts()
        {
            var expected = new List<string>() { "chocolate", "tomatoes" ,"peanuts" };

            var utility = new Utility();
            var actual = utility.DetermineListOfAllergies(50);

            CollectionAssert.AreEqual(expected, actual);
        }

        public void ScoreOfOneHundredAllergicToPollenChocolateAndShellfish()
        {
            var expected = new List<string>() { "pollen", "chocolate", "shellfish" };

            var utility = new Utility();
            var actual = utility.DetermineListOfAllergies(100);

            CollectionAssert.AreEqual(expected, actual);
        }

        public void ScoreOfTwoHundredFortyEightAllergicToCatsPollenChocolateTomatoesAndStrawberries()
        {
            var expected = new List<string>() { "cats", "pollen", "chocolate", "tomatoes", "strawberries" };

            var utility = new Utility();
            var actual = utility.DetermineListOfAllergies(248);

            CollectionAssert.AreEqual(expected, actual);
        }

        public void ScoreOfTwoHundredFiftyFiveAllergicToCatsPollenChocolateTomatoesStrawberriesShellfishPeanutsAndEggs()
        {
            var expected = new List<string>() { "cats", "pollen", "chocolate", "tomatoes", "strawberries", "shellfish", "peanuts", "eggs" };

            var utility = new Utility();
            var actual = utility.DetermineListOfAllergies(255);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
