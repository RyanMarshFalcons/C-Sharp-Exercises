using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minimum_Concatenation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Minimum_Concatenation_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForEmptyString()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForW()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("W");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3ForHamSandwich()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.GetMinimum("Ham", "Sandwich");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4ForApplePear()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetMinimum("Apple", "Pear");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnscofcupForcoffeecup()
        {
            var expected = "cofcup";

            var utility = new Utility();
            var actual = utility.CreateNewString("coffee", "cup", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsbowlocerealForbowlofcereal()
        {
            var expected = "bowl ocereal";

            var utility = new Utility();
            var actual = utility.CreateNewString("bowl of ", "cereal", 6);

            Assert.AreEqual(expected, actual);
        }
    }
}
