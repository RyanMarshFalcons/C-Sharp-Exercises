using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringY;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringY_Tests
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
        public void ReturnsFalseForf()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("f");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForabcdefghijklmnop()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfStringY("abcdefghijklmnop");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForYouyellPretty()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfStringY("You yell pretty.");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForRyanisacoolguy()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfStringY("Ryan is a cool guy");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForRyanEisaecoolguEy()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfStringY("Ryan is aY cool guy");

            Assert.AreEqual(expected, actual);
        }
    }
}
