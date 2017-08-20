using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index_Three_Chars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Index_Three_Chars_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForOn()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("on");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForOne()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("one");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0ForMin()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetMaxIndex("min");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns6ForMiniscule()
        {
            var expected = 6;

            var utility = new Utility();
            var actual = utility.GetMaxIndex("miniscule");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor10()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("10");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForP()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("P");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative14()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsInRange("-1", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor54()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsInRange("5", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor14()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsInRange("1", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnscooForRyanisacoolguy10()
        {
            var expected = "coo";

            var utility = new Utility();
            var actual = utility.CreateNewString("Ryan is a cool guy", 10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnstouFortouchdowndance0()
        {
            var expected = "tou";

            var utility = new Utility();
            var actual = utility.CreateNewString("touchdown dance", 0);

            Assert.AreEqual(expected, actual);
        }
    }
}
