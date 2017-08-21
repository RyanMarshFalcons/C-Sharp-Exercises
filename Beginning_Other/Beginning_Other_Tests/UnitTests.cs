using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beginning_Other;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Beginning_Other_Tests
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
        public void ReturnsTrueForE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForSetLets()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSameLength("Set", "Lets");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForSetsLets()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSameLength("Sets", "Lets");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForMetPet()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSameString("Met", "Pet");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMetMet()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSameString("Met", "Met");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForBusTruck()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfFirstIsLonger("Bus", "Truck");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForAutomobileCar()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfFirstIsLonger("Automobile", "Car");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForABCABCDEFG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfShorterIsBeginningOfLonger("ABC", "ABCDEFG", false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForEFGABCDEFG()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfShorterIsBeginningOfLonger("EFG", "ABCDEFG", false);

            Assert.AreEqual(expected, actual);
        }
    }
}
