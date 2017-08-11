using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap_Year;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leap_Year_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor1998()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfYear("1998");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNot19point98()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfYear("19.98");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForLeapYear()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLeapYear(2004);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNotLeapYear()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLeapYear(2005);

            Assert.AreEqual(expected, actual);
        }
    }
}
