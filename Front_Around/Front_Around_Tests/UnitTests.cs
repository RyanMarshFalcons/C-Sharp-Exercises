using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_Around;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Front_Around_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForb()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("b");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRRyanRForRyan()
        {
            var expected = "RRyanR";

            var utility = new Utility();
            var actual = utility.AddFirstToFrontAndBack("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTTenniscourtTForTenniscourt()
        {
            var expected = "TTennis courtT";

            var utility = new Utility();
            var actual = utility.AddFirstToFrontAndBack("Tennis court");

            Assert.AreEqual(expected, actual);
        }
    }
}
