using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Back_Around;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Back_Around_Tests
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
        public void ReturnsFalseFora()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("a");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsnRyannForRyan()
        {
            var expected = "nRyann";

            var utility = new Utility();
            var actual = utility.AddLastToFrontAndBack("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnstTenniscourttForTenniscourt()
        {
            var expected = "tTennis courtt";

            var utility = new Utility();
            var actual = utility.AddLastToFrontAndBack("Tennis court");

            Assert.AreEqual(expected, actual);
        }
    }
}
