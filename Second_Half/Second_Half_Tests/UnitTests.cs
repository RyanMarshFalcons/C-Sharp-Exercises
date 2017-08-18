using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Second_Half;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Second_Half_Tests
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
        public void ReturnsFalseForG()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForgoat()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEvenLength("goat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForgoats()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEvenLength("goats");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsanForRyan()
        {
            var expected = "an";

            var utility = new Utility();
            var actual = utility.MakeNewString("Ryan", true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsraryForlibrary()
        {
            var expected = "rary";

            var utility = new Utility();
            var actual = utility.MakeNewString("library", false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsrgoallForsoccergoal()
        {
            var expected = "r goal";

            var utility = new Utility();
            var actual = utility.MakeNewString("soccer goal", false);

            Assert.AreEqual(expected, actual);
        }
    }
}