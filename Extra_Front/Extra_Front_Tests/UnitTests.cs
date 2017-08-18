using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extra_Front;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extra_Front_Tests
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
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForBC()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("BC");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyRyRyForRyan()
        {
            var expected = "RyRyRy";

            var utility = new Utility();
            var actual = utility.MakeNewString("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnslililiForlibrary()
        {
            var expected = "lilili";

            var utility = new Utility();
            var actual = utility.MakeNewString("library");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsGoGoGoForGoallllllexclamationpoint()
        {
            var expected = "GoGoGo";

            var utility = new Utility();
            var actual = utility.MakeNewString("Goallllll!");

            Assert.AreEqual(expected, actual);
        }
    }
}
