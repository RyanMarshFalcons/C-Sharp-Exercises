using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringE_Tests
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
        public void ReturnsFalseFore()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("e");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForabcdefghijklmnop()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfStringE("abcdefghijklmnop");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForabcdefghijklmnopEE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfStringE("abcdefghijklmnopEE");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForRyanisacoolguy()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfStringE("Ryan is a cool guy");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForRyanEisaecoolguEy()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfStringE("RyanE is ae cool guEy");

            Assert.AreEqual(expected, actual);
        }
    }
}
