using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Double_Characters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Double_Characters_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForEmptyString()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFora()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("a");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRRuunnnneerrForRunner()
        {
            var expected = "RRuunnnneerr";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssspprriinnggttiimmeeForspringtime()
        {
            var expected = "sspprriinngg  ttiimmee";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
