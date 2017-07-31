using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Division;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Division_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseForCalifornia()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("California");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative425point187()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("-425.187");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4For64And16()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetQuotient(64, 16);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns8For56And7()
        {
            var expected = 8;

            var utility = new Utility();
            var actual = utility.GetQuotient(56, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3point71For4point56And1point23()
        {
            var expected = 3.71;

            var utility = new Utility();
            var actual = utility.GetQuotient(4.56, 1.23);

            Assert.AreEqual(expected, actual);
        }
    }
}
