using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Front_5_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForboar()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("boar");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForboard()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("board");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForboards()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("boards");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRunneRunneRunneRunneRunneForRunner()
        {
            var expected = "RunneRunneRunneRunneRunne";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssprinsprinsprinsprinsprinForspringtime()
        {
            var expected = "sprinsprinsprinsprinsprin";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
