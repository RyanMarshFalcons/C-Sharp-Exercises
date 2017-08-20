using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index_Four_Chars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Index_Three_Chars_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForOne()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("one");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForOnes()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("ones");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0ForMine()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetMaxIndex("mine");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5ForMiniscule()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.GetMaxIndex("miniscule");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor11()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("11");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForQ()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("Q");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative15()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsInRange("-1", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor65()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsInRange("6", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor15()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsInRange("1", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnscoolForRyanisacoolguy10()
        {
            var expected = "cool";

            var utility = new Utility();
            var actual = utility.CreateNewString("Ryan is a cool guy", 10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnstoucFortouchdowndance0()
        {
            var expected = "touc";

            var utility = new Utility();
            var actual = utility.CreateNewString("touchdown dance", 0);

            Assert.AreEqual(expected, actual);
        }
    }
}
