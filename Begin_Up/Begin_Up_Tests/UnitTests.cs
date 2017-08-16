using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Begin_Up;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Begin_Up_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForba()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("ba");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForbat()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("bat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsABCforabc()
        {
            var expected = "ABC";

            var utility = new Utility();
            var actual = utility.MakeBeginningUpperCase("abc");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsABRacadabraForabracadabra()
        {
            var expected = "ABRacadabra";

            var utility = new Utility();
            var actual = utility.MakeBeginningUpperCase("abracadabra");

            Assert.AreEqual(expected, actual);
        }
    }
}
