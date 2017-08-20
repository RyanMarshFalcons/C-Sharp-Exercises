using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_Z;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Without_Z_Tests
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
        public void ReturnsTrueForO()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("O");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyanForZzzzzzzzzzRyanzzzzzzzzzzZ()
        {
            var expected = "Ryan";

            var utility = new Utility();
            var actual = utility.CreateNewString("ZzzzzzzzzzRyanzzzzzzzzzzZ");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsspringZzZZzZtimeForspringZzZZzZtime()
        {
            var expected = "springZzZ ZzZtime";

            var utility = new Utility();
            var actual = utility.CreateNewString("springZzZ ZzZtime");

            Assert.AreEqual(expected, actual);
        }
    }
}