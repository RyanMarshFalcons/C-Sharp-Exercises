using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_Four;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Three_Four_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForredsox()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("redsox");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForredsock()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("redsock");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsumbecucForcucumber()
        {
            var expected = "umbecuc";

            var utility = new Utility();
            var actual = utility.CreateNewString("cucumber");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsermsupscaanApostrohpeForsupermanApostrophescape()
        {
            var expected = "er msups caan'";

            var utility = new Utility();
            var actual = utility.CreateNewString("super man's cape");

            Assert.AreEqual(expected, actual);
        }
    }
}
