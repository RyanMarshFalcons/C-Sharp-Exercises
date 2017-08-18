using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extra_End;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extra_End_Tests
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
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForAB()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("AB");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsanananForRyan()
        {
            var expected = "ananan";

            var utility = new Utility();
            var actual = utility.MakeNewString("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsryryryForlibrary()
        {
            var expected = "ryryry";

            var utility = new Utility();
            var actual = utility.MakeNewString("library");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnslexclamationpointlexclamationpointlexclamationpointForGoallllllexclamationpoint()
        {
            var expected = "l!l!l!";

            var utility = new Utility();
            var actual = utility.MakeNewString("Goallllll!");

            Assert.AreEqual(expected, actual);
        }
    }
}
