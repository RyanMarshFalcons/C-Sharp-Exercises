using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Every_Fourth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Every_Fourth_Tests
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
        public void ReturnsFalseForc()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("c");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsaForabc()
        {
            var expected = "a";

            var utility = new Utility();
            var actual = utility.FormStringFromEveryFourthChar("abc");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsacbForabracadabra()
        {
            var expected = "acb";

            var utility = new Utility();
            var actual = utility.FormStringFromEveryFourthChar("abracadabra");

            Assert.AreEqual(expected, actual);
        }
    }
}
