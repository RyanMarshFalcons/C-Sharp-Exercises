using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Every_Fifth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Every_Fifth_Tests
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
        public void ReturnsFalseFord()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("d");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsaForabc()
        {
            var expected = "a";

            var utility = new Utility();
            var actual = utility.FormStringFromEveryFifthChar("abc");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsaaaForabracadabra()
        {
            var expected = "aaa";

            var utility = new Utility();
            var actual = utility.FormStringFromEveryFifthChar("abracadabra");

            Assert.AreEqual(expected, actual);
        }
    }
}
