using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Middle_Around;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Middle_Around_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForhe()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("he");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForher()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("her");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsnRyannForRyan()
        {
            var expected = "yaRyanya";

            var utility = new Utility();
            var actual = utility.AddMiddleToFrontAndBack("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssTenniscourtsForTenniscourt()
        {
            var expected = "s Tennis courts ";

            var utility = new Utility();
            var actual = utility.AddMiddleToFrontAndBack("Tennis court");

            Assert.AreEqual(expected, actual);
        }
    }
}
