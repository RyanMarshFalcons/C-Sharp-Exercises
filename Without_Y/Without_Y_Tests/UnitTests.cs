using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_Y;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Without_Y_Tests
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
        public void ReturnsTrueForN()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidString("N");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsRyanForYyYyRyanyYyY()
        {
            var expected = "Ryan";

            var utility = new Utility();
            var actual = utility.CreateNewString("YyYyRyanyYyY");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsspringYYYyyytimeForspringYYYyyytime()
        {
            var expected = "springYYY yyytime";

            var utility = new Utility();
            var actual = utility.CreateNewString("springYYY yyytime");

            Assert.AreEqual(expected, actual);
        }
    }
}