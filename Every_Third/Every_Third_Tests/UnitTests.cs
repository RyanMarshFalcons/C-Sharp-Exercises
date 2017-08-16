using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Every_Third;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Every_Third_Tests
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
        public void ReturnsaForabc()
        {
            var expected = "a";

            var utility = new Utility();
            var actual = utility.FormStringFromEveryThirdChar("abc");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsaadrForabracadabra()
        {
            var expected = "aadr";

            var utility = new Utility();
            var actual = utility.FormStringFromEveryThirdChar("abracadabra");

            Assert.AreEqual(expected, actual);
        }
    }
}
