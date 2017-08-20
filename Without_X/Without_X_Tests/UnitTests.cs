using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_X;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Without_X_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForEmptyString()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForM()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyanForXxXxRyanxXxX()
        {
            var expected = "Ryan";

            var utility = new Utility();
            var actual = utility.CreateNewString("XxXxRyanxXxX");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsspringXxtimeForspringXxtime()
        {
            var expected = "springX xtime";

            var utility = new Utility();
            var actual = utility.CreateNewString("springX xtime");

            Assert.AreEqual(expected, actual);
        }
    }
}