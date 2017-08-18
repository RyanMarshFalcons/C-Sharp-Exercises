using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extra_Middle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extra_Middle_Tests
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
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForCDE()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("CDE");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForboat()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEvenLength("boat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForboats()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEvenLength("boats");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsyayayaForRyan()
        {
            var expected = "yayaya";

            var utility = new Utility();
            var actual = utility.MakeNewString("Ryan", true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsbrabraForlibrary()
        {
            var expected = "brabra";

            var utility = new Utility();
            var actual = utility.MakeNewString("library", false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsllllllForGoallllllexclamationpoint()
        {
            var expected = "llllll";

            var utility = new Utility();
            var actual = utility.MakeNewString("Goallllll!", true);

            Assert.AreEqual(expected, actual);
        }
    }
}
