using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_Again_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Front_Again_1_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForT()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("T");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForTT()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLongEnough("TT");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRForRyan()
        {
            var expected = "R";

            var utility = new Utility();
            var actual = utility.GetBegining("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsCForCalifornia()
        {
            var expected = "C";

            var utility = new Utility();
            var actual = utility.GetBegining("California");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsnForRyan()
        {
            var expected = "n";

            var utility = new Utility();
            var actual = utility.GetEnding("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsaForCalifornia()
        {
            var expected = "a";

            var utility = new Utility();
            var actual = utility.GetEnding("California");

            Assert.AreEqual(expected, actual);
        }
    }
}

