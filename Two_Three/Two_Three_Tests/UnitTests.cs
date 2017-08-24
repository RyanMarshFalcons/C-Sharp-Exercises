using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Two_Three;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Two_Three_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForford()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("ford");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForfords()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("fords");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnscumcuForcucumber()
        {
            var expected = "cumcu";

            var utility = new Utility();
            var actual = utility.CreateNewString("cucumber");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsupspersuanApostrophemcapsForsupermanApostrophescape()
        {
            var expected = "persuan' mcaps ";

            var utility = new Utility();
            var actual = utility.CreateNewString("super man's cape");

            Assert.AreEqual(expected, actual);
        }
    }
}
