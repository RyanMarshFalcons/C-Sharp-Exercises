using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_First_Last;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Without_First_Last_Tests
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
        public void ReturnsTrueForH()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForHI()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("HI");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsyaForRyan()
        {
            var expected = "ya";

            var utility = new Utility();
            var actual = utility.MakeNewString("Ryan");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsibrarForlibrary()
        {
            var expected = "ibrar";

            var utility = new Utility();
            var actual = utility.MakeNewString("library");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsroccergoaForsoccergoal()
        {
            var expected = "occer goa";

            var utility = new Utility();
            var actual = utility.MakeNewString("soccer goal");

            Assert.AreEqual(expected, actual);
        }
    }
}
