using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Front_3_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForHi()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("Hi");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForHit()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("Hit");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForHits()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("Hits");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRunRunRunForRunner()
        {
            var expected = "RunRunRun";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssprsprsprForspringtime()
        {
            var expected = "sprsprspr";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
