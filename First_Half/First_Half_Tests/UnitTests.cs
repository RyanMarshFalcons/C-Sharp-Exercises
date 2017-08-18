using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First_Half;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace First_Half_Tests
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
        public void ReturnsFalseForF()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFormoat()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEvenLength("moat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFormoats()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEvenLength("moats");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyForRyan()
        {
            var expected = "Ry";

            var utility = new Utility();
            var actual = utility.MakeNewString("Ryan", true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnslibrForlibrary()
        {
            var expected = "libr";

            var utility = new Utility();
            var actual = utility.MakeNewString("library", false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsGoallForGoallllll()
        {
            var expected = "Goall";

            var utility = new Utility();
            var actual = utility.MakeNewString("Goallllll", false);

            Assert.AreEqual(expected, actual);
        }
    }
}