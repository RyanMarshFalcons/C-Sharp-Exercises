using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Left_To_End_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Left_To_End_3_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForcar()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("car");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForcars()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("cars");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForcarls()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("carls");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsnerRunForRunner()
        {
            var expected = "nerRun";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsingtimesprForspringtime()
        {
            var expected = "ing timespr";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
