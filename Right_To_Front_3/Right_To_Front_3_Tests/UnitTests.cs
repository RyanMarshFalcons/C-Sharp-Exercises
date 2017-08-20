using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Right_To_Front_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Right_To_Front_3_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForhat()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("hat");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForhate()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("hate");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForhates()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("hates");

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
        public void ReturnsimespringtForspringtime()
        {
            var expected = "imespring t";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
