using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_And_Back;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Front_And_Back_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForI()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForhi()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("hi");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsnyaRForRyan()
        {
            var expected = "nyaR";

            var utility = new Utility();
            var actual = utility.SwapFirstAndLast("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsruperdupesForsuperduper()
        {
            var expected = "ruper dupes";

            var utility = new Utility();
            var actual = utility.SwapFirstAndLast("super duper");

            Assert.AreEqual(expected, actual);
        }
    }
}
