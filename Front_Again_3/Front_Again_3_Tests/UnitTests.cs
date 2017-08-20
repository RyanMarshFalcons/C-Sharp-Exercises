using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_Again_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Front_Again_3_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForhouse()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("house");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForhouses()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("houses");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyaForRyan()
        {
            var expected = "Rya";

            var utility = new Utility();
            var actual = utility.GetBegining("Rya");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCalForCalifornia()
        {
            var expected = "Cal";

            var utility = new Utility();
            var actual = utility.GetBegining("California");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsyanForRyan()
        {
            var expected = "yan";

            var utility = new Utility();
            var actual = utility.GetEnding("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsniaForCalifornia()
        {
            var expected = "nia";

            var utility = new Utility();
            var actual = utility.GetEnding("California");

            Assert.AreEqual(expected, actual);
        }
    }
}

