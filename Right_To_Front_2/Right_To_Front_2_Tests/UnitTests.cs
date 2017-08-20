using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Right_To_Front_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Right_To_Front_2_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseFormy()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("my");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFormin()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("min");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFormine()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("mine");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnserRunnForRunner()
        {
            var expected = "erRunn";

            var utility = new Utility();
            var actual = utility.CreateNewString("Runner");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsmespringtiForspringtime()
        {
            var expected = "mespring ti";

            var utility = new Utility();
            var actual = utility.CreateNewString("spring time");

            Assert.AreEqual(expected, actual);
        }
    }
}
