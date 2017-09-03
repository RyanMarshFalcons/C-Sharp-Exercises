using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String_Count_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnFalseForv()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("v");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns15LettersForRyansawesomehesnumber1()
        {
            var expected = 15;

            var utility = new Utility();
            var actual = utility.CountLettersInString("Ryan's awesome, he's #1!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1NumberForRyansawesomehesnumber1()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.CountNumbersInString("Ryan's awesome, he's #1!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3SpacesForRyansawesomehesnumber1()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.CountSpacesInString("Ryan's awesome, he's #1!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5SymbolsForRyansawesomehesnumber1()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.CountSymbolsInString("Ryan's awesome, he's #1!");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns30LettersFor1Wakeup2Makecoffee3Write500wordpaperp()
        {
            var expected = 31;

            var utility = new Utility();
            var actual = utility.CountLettersInString("1) Wake up! 2) Make coffee :) 3) Write 500 word paper :p");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns6NumbersFor1Wakeup2Makecoffee3Write500wordpaperp()
        {
            var expected = 6;

            var utility = new Utility();
            var actual = utility.CountNumbersInString("1) Wake up! 2) Make coffee :) 3) Write 500 word paper :p");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns12SpacesFor1Wakeup2Makecoffee3Write500wordpaperp()
        {
            var expected = 12;

            var utility = new Utility();
            var actual = utility.CountSpacesInString("1) Wake up! 2) Make coffee :) 3) Write 500 word paper :p");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns7SymbolsFor1Wakeup2Makecoffee3Write500wordpaperp()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.CountSymbolsInString("1) Wake up! 2) Make coffee :) 3) Write 500 word paper :p");

            Assert.AreEqual(expected, actual);
        }
    }
}
