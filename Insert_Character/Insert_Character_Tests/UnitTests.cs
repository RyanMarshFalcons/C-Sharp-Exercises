using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insert_Character;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Insert_Character_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor23()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("23");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForw()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("w");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative7()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor7()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor78()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfIndexExists("7", 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor99()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfIndexExists("9", 9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrainTwreckForTrainwreck5T()
        {
            var expected = "TrainTwreck";

            var utility = new Utility();
            var actual = utility.GetNewString("Trainwreck", 5, "T");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyanisacoolguyExclamationPointForRyanisacoolguy10ExclamationPoint()
        {
            var expected = "Ryan is a cool guy!";

            var utility = new Utility();
            var actual = utility.GetNewString("Ryan is a cool guy", 18, "!");

            Assert.AreEqual(expected, actual);
        }
    }
}
