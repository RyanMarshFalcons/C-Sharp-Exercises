using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index_Five_Chars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Index_Three_Chars_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForhome()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("home");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForhouse()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("house");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0ForMine()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetMaxIndex("mines");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5ForMiniscule()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetMaxIndex("miniscule");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor17()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("17");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForR()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("R");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative16()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsInRange("-1", 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor76()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsInRange("7", 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor16()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsInRange("1", 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnscoolForRyanisacoolguy10()
        {
            var expected = "cool ";

            var utility = new Utility();
            var actual = utility.CreateNewString("Ryan is a cool guy", 10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnstouchFortouchdowndance0()
        {
            var expected = "touch";

            var utility = new Utility();
            var actual = utility.CreateNewString("touchdown dance", 0);

            Assert.AreEqual(expected, actual);
        }
    }
}
