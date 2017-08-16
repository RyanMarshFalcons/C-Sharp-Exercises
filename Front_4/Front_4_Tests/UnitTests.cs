using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Front_4_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForlam()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("lam");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForlame()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("lame");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForlamer()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("lamer");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRunnRunnRunnRunnForRunner()
        {
            var expected = "RunnRunnRunnRunn";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnssprisprisprispriForspringtime()
        {
            var expected = "sprisprisprispri";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
