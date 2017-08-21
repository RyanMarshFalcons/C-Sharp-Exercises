using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using End_Other;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace End_Other_Tests
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
            var actual = utility.CheckIfLongEnough("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForBatHats()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSameLength("Bat", "Hats");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForBatsHats()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSameLength("Bats", "Hats");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForMatSat()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfSameString("Mat", "Sat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForMatMat()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfSameString("Mat", "Mat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForTrainAirplane()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfFirstIsLonger("Train", "Airplane");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTrainsPlane()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfFirstIsLonger("Trains", "Plane");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForABCABCDEFG()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfShorterIsEndOfLonger("ABC", "ABCDEFG", false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForEFGABCDEFG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfShorterIsEndOfLonger("EFG", "ABCDEFG", false);

            Assert.AreEqual(expected, actual);
        }
    }
}
