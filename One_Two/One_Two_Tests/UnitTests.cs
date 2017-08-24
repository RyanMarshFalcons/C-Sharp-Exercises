using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using One_Two;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace One_Two_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForup()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("up");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForups()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("ups");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsuccbumForcucumber()
        {
            var expected = "uccmbu";

            var utility = new Utility();
            var actual = utility.CreateNewString("cucumber");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsupsreanmsApostropheapcForsupermanApostrophescape()
        {
            var expected = "upsr eanms 'apc";

            var utility = new Utility();
            var actual = utility.CreateNewString("super man's cape");

            Assert.AreEqual(expected, actual);
        }
    }
}
